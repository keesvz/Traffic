#region Todo
/*
 * Fix bug in passing while vehicle in front slows down
 * Two-way lanes
 * Rubber-necking
 * Multi-colored vehicles
 */
#endregion
#region Info
/*
 * display: 64Hz --> 64 updates/s
 * 1 pixel = 0.25m
 * car width: 2m = 8 pixels
 * car length: 5m = 20 pixels
 * truck length: 15m = 60 pixels
 * road width: 5m = 20 pixels
 * speed: 100 km/h = 100*1000/0.25 pixels/3,600 s = 111.11 pixels/s --> 111.11 / 64 = 1.7361 pixels/update
 *        100 km/h = 27.778 m/s
 * lane change: 48 updates = 0.75s
 * 
 * screen width takes 1272 pixels / 111.11 pixels/s ~ 11.45s
 * 
 * new vehicles start at x(front of vehicle) = 0 and vehicle.MetersTraveled = -vehicle.Length
 */
#endregion

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Traffic
{
    public partial class TrafficSimulator : Form
    {
        #region GUI constants
        public const float LANE_WIDTH = 20f;
        public const float ROAD_WIDTH = 2 * LANE_WIDTH + 1;
        public const float MEDIAN_WIDTH = 30f;
        private readonly int SCREEN_WIDTH = Screen.PrimaryScreen.Bounds.Width;
        private readonly int SCREEN_HEIGHT = Screen.PrimaryScreen.Bounds.Height/*500;*/;
        private const int CANVAS_OFFSET = 10;
        #endregion

        #region Constants
        public const float VEHICLE_WIDTH_IN_PIXELS = 8f;
        public const float CAR_LENGTH_IN_PIXELS = 20f;
        public const float TRUCK_LENGTH_IN_PIXELS = 3f * CAR_LENGTH_IN_PIXELS;
        public const int PASSING_STEPS = 48;
        public const float METERS_PER_PIXEL = 0.25f;
        private readonly int NR_STRIPES;
        public readonly int PASSING_STEP_MIN;
        public readonly int PASSING_STEP_MAX;
        private readonly float METERS_TO_DESTINATION;
        private const float MINIMUM_TIME_BETWEEN_VEHICLES = 0.2f;
        private const float DEF_SPEED_IN_METERS_PER_SECOND = 100f / 3.6f; // 100 km/h
        private const float UPDATES_PER_SECOND = 64f;
        private const float CAR_LENGTH_IN_METERS = CAR_LENGTH_IN_PIXELS * METERS_PER_PIXEL;
        private const float TRUCK_LENGTH_IN_METERS = TRUCK_LENGTH_IN_PIXELS * METERS_PER_PIXEL;
        private const float CELL_LENGTH_IN_METERS = CAR_LENGTH_IN_METERS;
        private const int TIMER_INTERVAL = 15; // Anything < 16 will have the same update rate, as timer has min. resolution of 64Hz (15.625ms)
        private const double TWO_PI = 2.0 * Math.PI;
        private const int ROAD_BLOCK_DISTANCE_IN_METERS = 1000;
        private const float MAX_CAR_SPEED = 180f; // km/h

private const float MAX_CAR_ACCELERATION = 10f; // km/h/s
private const float MAX_CAR_DECELERATION = 20f; // km/h/s
private const float MAX_TRUCK_SPEED = 130f;
private const float MAX_TRUCK_ACCELERATION = 0f;
private const float MAX_TRUCK_DECELERATION = 0f;
        #endregion

        #region Fields
        private Canvas canvas;
        private static Size bounds;
        private Timer timer = new Timer();
        private List<Vehicle> vehicles = new List<Vehicle>();
        private bool running = false;
        private DateTime nextVehicleTime;
        private long ticksLeft = 0;
        private Random rnd = null;
        private DateTime startTime = DateTime.MinValue;
        private DateTime stopTime = DateTime.MinValue;
        private int nrVehiclesExited = 0;
        #endregion

        #region Properties
        public bool Running { get { return running; } }
        public List<Vehicle> Vehicles { get { return vehicles; } }
        public bool RoadBlock { get { return chkRoadBlock.Checked; } }
        public int RoadBlockDistanceInMeters { get { return ROAD_BLOCK_DISTANCE_IN_METERS; } }
        public bool PassOnRight { get { return chkPassOnRight.Checked; } }
        #endregion

        #region Constructor
        public TrafficSimulator()
        {
            InitializeComponent();

            // Setup main window
            this.Location = new Point(0, 0);
            this.Size = new Size(SCREEN_WIDTH, SCREEN_HEIGHT);
            bounds = this.ClientSize;

            // Set up canvas
            this.canvas = new Canvas(this);
            this.canvas.Size = new Size(bounds.Width, bounds.Height - parameterGroupBox.Bottom - CANVAS_OFFSET);
            this.canvas.Location = new Point(0, parameterGroupBox.Bottom + CANVAS_OFFSET);
            this.Controls.Add(canvas);

            // Set constants
            NR_STRIPES = (int)((canvas.Height + MEDIAN_WIDTH) / (MEDIAN_WIDTH + ROAD_WIDTH));
            METERS_TO_DESTINATION = NR_STRIPES * (float)bounds.Width * METERS_PER_PIXEL;
            PASSING_STEP_MIN = (int)(((LANE_WIDTH - VEHICLE_WIDTH_IN_PIXELS) / 2 + 1) * PASSING_STEPS / (LANE_WIDTH + 1));
            PASSING_STEP_MAX = (int)(((LANE_WIDTH + VEHICLE_WIDTH_IN_PIXELS) / 2 + 1) * PASSING_STEPS / LANE_WIDTH);

            var oldCanvasHeight = canvas.Height;
            canvas.Height = (int)(NR_STRIPES * (MEDIAN_WIDTH + ROAD_WIDTH));
            //this.Height -= oldCanvasHeight - canvas.Height;

            lblStripLength.Text = ((int)((float)bounds.Width * METERS_PER_PIXEL)).ToString();
            lblRoadLength.Text = ((int)(NR_STRIPES * (float)bounds.Width * METERS_PER_PIXEL) / 1000f).ToString("0.0");

            // Start timer
            timer.Enabled = false;
            timer.Interval = TIMER_INTERVAL;
            timer.Tick += new EventHandler(timer_Tick);
        }
        #endregion

        #region Methods
        public void AddVehicle(float variability)
        {
            // Set vehicle type; P(car) = 1 - P(truck) = 1 / (1 + ratio)
            var isTruck = rnd.NextDouble() < (1.0 - 1.0 / (1.0 + (double)truckCarRatioUpDown.Value));

            // Set driver type
            DriverType driverType = DriverType.Conformist;
            if ((rnd.Next(1000) < (int)(1000.0 * (double)nudSpeederProbability.Value)) && !(chkTruckMaxSpeed.Checked && isTruck))
                driverType = DriverType.Speeder;
            else if (rnd.Next(1000) < (int)(1000.0 * (double)nudSlowPokeProbability.Value))
                driverType = DriverType.SlowPoke;
            
            // Add vehicle (first vehicle in list is furthest away)
            vehicles.Add(new Vehicle(this, GetSpeedInMetersPerSecond(variability, driverType, isTruck), isTruck, Lane.Right, driverType));

            // Set time for next vehicle to enter
            double timeBetweenVehicles = (double)timeBetweenVehiclesUpDown.Value;
            timeBetweenVehicles += (double)rnd.Next(-(int)(100 * timeVariabilityUpDown.Value), (int)(100 * timeVariabilityUpDown.Value)) / 100.0;
            if (timeBetweenVehicles < MINIMUM_TIME_BETWEEN_VEHICLES)
                timeBetweenVehicles = MINIMUM_TIME_BETWEEN_VEHICLES;
            nextVehicleTime = new DateTime(DateTime.Now.Ticks + (long)(timeBetweenVehicles * 10000000.0));
        }

        private float GetSpeedInMetersPerSecond(float variability, DriverType driverType, bool isTruck)
        {
            if (!isTruck || (isTruck && !chkTruckMaxSpeed.Checked))
            {
                var mean = 100.0;
                if (driverType == DriverType.SlowPoke)
                    mean = 70.0;
                else if (driverType == DriverType.Speeder)
                    mean = 130.0;

                return (float)NextGaussian(mean, variability * Math.Sqrt(0.2)) / 3.6f;
            }
            else
            {
                var mean = (float)nudTruckMaxSpeed.Value;
                if (driverType == DriverType.SlowPoke)
                    mean -= 20f;

                var speed = (float)NextGaussian(mean, variability * Math.Sqrt(0.2)) / 3.6f;
                if (speed > (float)nudTruckMaxSpeed.Value)
                    speed = (float)nudTruckMaxSpeed.Value + 2f * (float)rnd.NextDouble() * (float)nudTruckMaxSpeedVariability.Value - (float)nudTruckMaxSpeedVariability.Value;

                return speed;
            }
        }

        // http://stackoverflow.com/questions/218060/random-gaussian-variables
        private double NextGaussian(double mean, double stdDev)
        {
            double u1 = rnd.NextDouble(); // uniform(0, 1) random doubles
            double u2 = rnd.NextDouble();
            double rndStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(TWO_PI * u2); // random normal(0, 1)
            return Math.Max(0, mean + stdDev * rndStdNormal); // random normal(mean, stdDev^2)
        }

        private void Stop()
        {
            timer.Stop();
            ticksLeft = nextVehicleTime.Ticks - DateTime.Now.Ticks;
            running = false;
            btnStart.Enabled = true;
            btnClear.Enabled = true;
            btnStop.Enabled = false;
            btnExit.Enabled = true;
            chkFixedSeed.Enabled = vehicles.Count == 0;
            chkFixedTime.Enabled = vehicles.Count == 0;
            nudMinutes.Enabled = vehicles.Count == 0;
            nudSeconds.Enabled = vehicles.Count == 0;
        }
        #endregion

        #region Event handlers
        private void btnClear_Click(object sender, EventArgs e)
        {
            running = false;
            vehicles.Clear();
            canvas.Refresh();
            ticksLeft = 0;
            btnStart.Enabled = true;
            btnClear.Enabled = false;
            btnStop.Enabled = false;
            chkRoadBlock.Enabled = true;
            chkFixedSeed.Enabled = true;
            chkFixedTime.Enabled = true;
            nudMinutes.Enabled = true;
            nudSeconds.Enabled = true;
            lblAveSpeed.Text = "---";
            lblMaxSpeed.Text = "---";
            lblMinSpeed.Text = "---";
            lblRunTime.Text = "---";
            lblVehiclesExited.Text = "0";
            lblVehiclesOnRoad.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (vehicles.Count == 0)
            {
                rnd = chkFixedSeed.Checked ? new Random(0) : new Random();
                AddVehicle((float)speedVariability.Value);
            }
            else
                nextVehicleTime = new DateTime(DateTime.Now.Ticks + ticksLeft);
            btnStart.Enabled = false;
            btnClear.Enabled = false;
            btnStop.Enabled = true;
            btnExit.Enabled = false;
            chkFixedSeed.Enabled = false;
            chkFixedTime.Enabled = false;
            nudMinutes.Enabled = false;
            nudSeconds.Enabled = false;
            if (!chkRoadBlock.Checked)
                chkRoadBlock.Enabled = false;
            else
            {
                vehicles.Add(new Vehicle(this, 0, true, Lane.Right, DriverType.RoadBlock));
                vehicles.Add(new Vehicle(this, 0, true, Lane.Left, DriverType.RoadBlock));
            }
            nrVehiclesExited = 0;
            startTime = DateTime.Now;
            stopTime = startTime.AddSeconds(60 * (int)nudMinutes.Value + (int)nudSeconds.Value);
            timer.Start();
            running = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            if (running)
            {
                float minSpeed = 0f, maxSpeed= 0f, avSpeed = 0f;

                // Update run time
                var runTime = DateTime.Now - startTime;

                // Stop if time's up
                if (chkFixedTime.Checked && (DateTime.Now > stopTime))
                    Stop();
                else
                {
                    // Remove invisible vehicles
                    Vehicle vehicle;
                    while ((vehicle = vehicles[0]).MetersTraveled >= METERS_TO_DESTINATION + vehicle.LengthInMeters)
                    {
                        vehicles.Remove(vehicle);
                        nrVehiclesExited++;
                    }

                    // Add vehicle
                    if (DateTime.Now >= nextVehicleTime)
                        AddVehicle((float)speedVariability.Value);

                    // Order vehicles by distance
                    vehicles = vehicles.OrderByDescending(v => v.MetersTraveled).ToList();

                    // Update vehicle lanes
                    for (int i = 0; i < vehicles.Count; i++)
                        vehicles[i].UpdateLane(vehicles, i);

                    // Update vehicle positions and speeds; calculate speed stats
                    vehicle = vehicles[0];
                    vehicle.UpdateDistance();
                    minSpeed = vehicle.SpeedInMetersPerSecond;
                    maxSpeed = vehicle.SpeedInMetersPerSecond;
                    avSpeed = vehicle.SpeedInMetersPerSecond;
                    for (int i = 1; i < vehicles.Count; i++)
                    {
                        vehicles[i].UpdateSpeed(vehicles, i);
                        avSpeed += vehicles[i].SpeedInMetersPerSecond;
                        if (vehicles[i].SpeedInMetersPerSecond < minSpeed)
                            minSpeed = vehicles[i].SpeedInMetersPerSecond;
                        else if (vehicles[i].SpeedInMetersPerSecond > maxSpeed)
                            maxSpeed = vehicles[i].SpeedInMetersPerSecond;
                    }
                }

                // Update screen
                lblMinSpeed.Text = (minSpeed * 3.6f).ToString("#0.0");
                lblAveSpeed.Text = ((avSpeed * 3.6f / vehicles.Count)).ToString("#0.0");
                lblMaxSpeed.Text = (maxSpeed * 3.6f).ToString("#0.0");
                lblRunTime.Text = (int)runTime.TotalMinutes + "m " + runTime.Seconds.ToString("00") + "s";
                lblVehiclesOnRoad.Text = vehicles.Count.ToString();
                lblVehiclesExited.Text = nrVehiclesExited.ToString();

                canvas.Refresh();
            }
        }
        #endregion

        #region Helper classes
        public class Vehicle
        {
            private static Brush SPEEDER_COLOR = new SolidBrush(Color.Orange);
            private static Brush CONFORMIST_COLOR = new SolidBrush(Color.DarkGreen);
            private static Brush SLOW_POKE_COLOR = new SolidBrush(Color.DarkGray);
            private static Brush ROAD_BLOCK_COLOR = new SolidBrush(Color.Red);

            private static int identifier = 0;
            private int id;
            private float speedInMetersPerUpdate;
            private float targetSpeedInMetersPerUpdate;
            private bool truck;
            private Lane lane;
            private float lengthInMeters;
            private DateTime start = DateTime.Now;
            private float metersTraveled;
            private Brush brush;
            private TrafficSimulator form;
            private DriverType driverType;
            private PassingState passingState = PassingState.None;
            private int passingStep = 0;

            public Vehicle(TrafficSimulator form, float targetSpeedInMetersPerSecond, bool truck, Lane lane, DriverType driverType)
            {
                this.id = Vehicle.identifier++;
                this.form = form;
                this.truck = truck;
                if (truck)
                    this.lengthInMeters = TRUCK_LENGTH_IN_METERS;
                else
                    this.lengthInMeters = CAR_LENGTH_IN_METERS;
                this.lane = lane;
                this.speedInMetersPerUpdate = this.targetSpeedInMetersPerUpdate = targetSpeedInMetersPerSecond / UPDATES_PER_SECOND;
                if (driverType == DriverType.RoadBlock)
                    this.metersTraveled = ROAD_BLOCK_DISTANCE_IN_METERS;
                else
                    this.metersTraveled = -lengthInMeters;
                this.driverType = driverType;
                //switch (driverType)
                //{
                //    case DriverType.Conformist: brush = CONFORMIST_COLOR; break;
                //    case DriverType.SlowPoke: brush = SLOW_POKE_COLOR; break;
                //    case DriverType.Speeder: brush = SPEEDER_COLOR; break;
                //    case DriverType.RoadBlock: brush = ROAD_BLOCK_COLOR; break;
                //}
                var rnd = new Random();
                if (driverType == DriverType.RoadBlock)
                    brush = ROAD_BLOCK_COLOR;
                else
                    brush = new SolidBrush(Color.FromArgb(rnd.Next(150), rnd.Next(150), rnd.Next(150)));
            }

            public void UpdateDistance()
            {
                metersTraveled += speedInMetersPerUpdate;
            }

            public void UpdateSpeed(List<Vehicle> vehicles, int index)
            {
                // Find closest vehicle ahead in same lane
                Vehicle vehicleInFront = null;
                for (int i = index; i >= Math.Max(index - 3, 0); i--)
                    if ((lane == vehicles[i].Lane) && (vehicles[i] != this))
                    {
                        vehicleInFront = vehicles[i];
                        break;
                    }

                // Adjust speed if needed
                if ((vehicleInFront == null) || (vehicleInFront.Back - Front > 20))
                    speedInMetersPerUpdate = 0.99f * speedInMetersPerUpdate + 0.01f * targetSpeedInMetersPerUpdate;
                else if ((SpeedInMetersPerSecond > vehicleInFront.SpeedInMetersPerSecond) && (vehicleInFront.Back - Front < 10))
                    speedInMetersPerUpdate = 0.9f * speedInMetersPerUpdate + 0.1f * (vehicleInFront.SpeedInMetersPerSecond / UPDATES_PER_SECOND);
                UpdateDistance();
            }

            public void UpdateLane(List<Vehicle> vehicles, int index)
            {
                // Continue lane change if in progress
                // Todo: check not smack into slowing-down car in front!
                if (passingState != PassingState.None)
                {
                    passingStep++;
                    if ((passingStep > form.PASSING_STEP_MIN) && (passingStep < form.PASSING_STEP_MAX))
                        lane = Lane.Both;
                    else if (passingStep == PASSING_STEPS)
                    {
                        lane = (passingState == PassingState.LR) ? Lane.Right : Lane.Left;
                        passingState = PassingState.None;
                    }
                    return;
                }

                // Change lanes?
                if (form.PassOnRight || (!form.PassOnRight && (lane == Lane.Right)))
                {
                    // Find closest vehicle ahead in same lane
                    Vehicle vehicleInFront = null;
                    for (int i = index; i >= Math.Max(index - 3, 0); i--)
                        if (((vehicles[i].Lane == lane) || (vehicles[i].Lane == Lane.Both)) && (vehicles[i] != this))
                        {
                            vehicleInFront = vehicles[i];
                            break;
                        }

                    // Need or want to pass?
                    if ((vehicleInFront != null)
                        && (vehicleInFront.Back - Front < 11)
                        && (((SpeedInMetersPerSecond > vehicleInFront.SpeedInMetersPerSecond)) || (TargetSpeedInMetersPerSecond > vehicleInFront.SpeedInMetersPerSecond)))
                    {
                        // Find closest vehicles in other lane
                        vehicleInFront = null;
                        for (int i = index; i >= Math.Max(index - 3, 0); i--)
                            if ((vehicles[i].Lane != lane) && (vehicles[i] != this))
                            {
                                vehicleInFront = vehicles[i];
                                break;
                            }

                        Vehicle vehicleInBack = null;
                        for (int i = index; i < Math.Min(index + 3, vehicles.Count); i++)
                            if ((vehicles[i].Lane != lane) && (vehicles[i] != this))
                            {
                                vehicleInBack = vehicles[i];
                                break;
                            }

                        // Pass if possible
                        if (((vehicleInBack == null) || (((Back - vehicleInBack.Front > 11) && (SpeedInMetersPerSecond > vehicleInBack.SpeedInMetersPerSecond)) || (Back - vehicleInBack.Front > 30)))
                            && ((vehicleInFront == null) || (((vehicleInFront.Back - Front > 11) && (SpeedInMetersPerSecond < vehicleInFront.SpeedInMetersPerSecond)) || (vehicleInFront.Back - Front > 30))))
                        {
                            passingState = (lane == Lane.Left) ? PassingState.LR : PassingState.RL;
                            passingStep = 0;
                        }
                    }
                }
                else if (lane == Lane.Left)
                {
                    // Find closest vehicles in other lane
                    Vehicle vehicleInFront = null;
                    for (int i = index; i >= Math.Max(index - 3, 0); i--)
                        if ((vehicles[i].Lane != Lane.Left) && (vehicles[i] != this))
                        {
                            vehicleInFront = vehicles[i];
                            break;
                        }

                    Vehicle vehicleInBack = null;
                    for (int i = index; i < Math.Min(index + 3, vehicles.Count); i++)
                        if ((vehicles[i].Lane != Lane.Left) && (vehicles[i] != this))
                        {
                            vehicleInBack = vehicles[i];
                            break;
                        }

                    // Change lane if possible
                    if (((vehicleInBack == null) || (Back - vehicleInBack.Front > 10)) &&
                        ((vehicleInFront == null) || (vehicleInFront.Back - Front > 20)))
                    {
                        passingState = PassingState.LR;
                        passingStep = 0;
                    }
                }
            }

            public int Id { get { return id; } }
            public float LengthInMeters { get { return lengthInMeters; } }
            public float MetersTraveled { get { return metersTraveled; } }
            public float Front { get { return metersTraveled + lengthInMeters; } }
            public float Back { get { return metersTraveled; } }
            public float SpeedInMetersPerSecond { get { return speedInMetersPerUpdate * UPDATES_PER_SECOND; } }
            public float TargetSpeedInMetersPerSecond { get { return targetSpeedInMetersPerUpdate * UPDATES_PER_SECOND; } }
            public Lane Lane { get { return lane; } }
            public bool Truck { get { return truck; } }
            public DriverType DriverType { get { return driverType; } }
            public PassingState PassingState { get { return passingState; } }
            public int PassingStep { get { return passingStep; } }
            public Brush Brush { get { return brush; } }
        }
        #endregion

        private void nudSpeederProbability_ValueChanged(object sender, EventArgs e)
        {
            if (nudSpeederProbability.Value + nudSlowPokeProbability.Value > 1)
                nudSlowPokeProbability.Value = 1 - nudSpeederProbability.Value;
        }

        private void nudSlowPokeProbability_ValueChanged(object sender, EventArgs e)
        {
            if (nudSlowPokeProbability.Value + nudSpeederProbability.Value > 1)
                nudSpeederProbability.Value = 1 - nudSlowPokeProbability.Value;
        }

        private void chkRoadBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (running)
            {
                vehicles.RemoveAt(0);
                vehicles.RemoveAt(0);
                chkRoadBlock.Enabled = false;
            }
        }
    }

    public enum DriverType { Conformist, SlowPoke, Speeder, RoadBlock };
    public enum PassingState { None, LR, RL }
    public enum Lane { Left, Right, Both }
}