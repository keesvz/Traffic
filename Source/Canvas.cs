using System;
using System.Drawing;
using System.Windows.Forms;

namespace Traffic
{
    public partial class Canvas : UserControl
    {
        #region GUI parameters
        private readonly Color BG_COLOR = Color.Green;
        private readonly Brush ROAD_BRUSH = Brushes.LightGray;
        private readonly Pen DIVIDER_PEN = new Pen(Color.Black);
        private const float V_OFFSET = 10f;
        #endregion

        #region Constants
        private float STRIDE_WIDTH_IN_PIXELS;
        private float HEIGHT_IN_PIXELS;
        private float LANE_H_IN_PIXELS;
        private float ROAD_H_IN_PIXELS;
        private float MEDIAN_H_IN_PIXELS;
        private float VEHICLE_WIDTH_IN_PIXELS;
        private float CAR_LENGTH_IN_PIXELS;
        private float TRUCK_LENGTH_IN_PIXELS;
        private float VEHICLE_ENTRY_POINT_Y_IN_PIXELS;
        private float METERS_PER_PIXEL;
        private float METERS_PER_STRIPE;
        private float V_STRIDE;
        private int MAX_PASSING_COUNT;
        #endregion

        #region Fields
        TrafficSimulator parent;
        #endregion

        #region Constructor
        public Canvas(TrafficSimulator parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.BackColor = BG_COLOR;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

            // Add event listeners
            this.Paint += new PaintEventHandler(OnPaint);
            this.SizeChanged += new EventHandler(OnSizeChanged);
        }
        #endregion

        #region Event handlers
        public void OnPaint(object sender, PaintEventArgs e)
        {
            // Paint road
            float y = V_OFFSET;
            while (y < HEIGHT_IN_PIXELS)
            {
                e.Graphics.FillRectangle(ROAD_BRUSH, 0f, y, STRIDE_WIDTH_IN_PIXELS, ROAD_H_IN_PIXELS);
                e.Graphics.DrawLine(DIVIDER_PEN, 0f, y + LANE_H_IN_PIXELS, STRIDE_WIDTH_IN_PIXELS, y + LANE_H_IN_PIXELS);
                y += ROAD_H_IN_PIXELS + MEDIAN_H_IN_PIXELS;
            }

            // Paint cars & trucks
            float x, lengthInPixels;
            int stripe;
            foreach (TrafficSimulator.Vehicle v in parent.Vehicles)
            {
                lengthInPixels = v.Truck ? TRUCK_LENGTH_IN_PIXELS : CAR_LENGTH_IN_PIXELS;
                stripe = (int)(v.MetersTraveled / METERS_PER_STRIPE);
                x = (v.MetersTraveled - stripe * METERS_PER_STRIPE) / METERS_PER_PIXEL;
                y = VEHICLE_ENTRY_POINT_Y_IN_PIXELS + stripe * V_STRIDE; // Right lane
                switch (v.PassingState)
                {
                    case PassingState.RL: y -= LANE_H_IN_PIXELS * v.PassingStep / MAX_PASSING_COUNT; break;
                    case PassingState.LR: y += -LANE_H_IN_PIXELS + LANE_H_IN_PIXELS * v.PassingStep / MAX_PASSING_COUNT; break;
                    default: if (v.Lane == Lane.Left) y -= LANE_H_IN_PIXELS; break;
                }
                if (x + lengthInPixels > STRIDE_WIDTH_IN_PIXELS)
                {
                    e.Graphics.FillRectangle(v.Brush, x, y, STRIDE_WIDTH_IN_PIXELS - x, VEHICLE_WIDTH_IN_PIXELS);
                    e.Graphics.FillRectangle(v.Brush, 0f, y + V_STRIDE, lengthInPixels - STRIDE_WIDTH_IN_PIXELS + x, VEHICLE_WIDTH_IN_PIXELS);
                }
                else
                    e.Graphics.FillRectangle(v.Brush, x, y, lengthInPixels, VEHICLE_WIDTH_IN_PIXELS);
            }

            //// Paint road block
            //if (parent.RoadBlock)
            //{
            //    stripe = (int)(parent.RoadBlockDistanceInMeters / METERS_PER_STRIPE);
            //    x = (parent.RoadBlockDistanceInMeters - stripe * METERS_PER_STRIPE) / METERS_PER_PIXEL;
            //    y = V_OFFSET + stripe * V_STRIDE;
            //    e.Graphics.FillRectangle(Brushes.Red, x, y, 10, 2 * LANE_H_IN_PIXELS + 1);
            //}
        }

        public void OnSizeChanged(object sender, EventArgs e)
        {
            // Set constants
            STRIDE_WIDTH_IN_PIXELS = (float)this.Width;
            HEIGHT_IN_PIXELS = (float)this.Height;
            LANE_H_IN_PIXELS = TrafficSimulator.LANE_WIDTH;
            ROAD_H_IN_PIXELS = TrafficSimulator.ROAD_WIDTH;
            MEDIAN_H_IN_PIXELS = TrafficSimulator.MEDIAN_WIDTH;
            VEHICLE_WIDTH_IN_PIXELS = TrafficSimulator.VEHICLE_WIDTH_IN_PIXELS;
            VEHICLE_ENTRY_POINT_Y_IN_PIXELS = V_OFFSET + ROAD_H_IN_PIXELS - (LANE_H_IN_PIXELS + VEHICLE_WIDTH_IN_PIXELS) / 2f;
            CAR_LENGTH_IN_PIXELS = TrafficSimulator.CAR_LENGTH_IN_PIXELS;
            TRUCK_LENGTH_IN_PIXELS = TrafficSimulator.TRUCK_LENGTH_IN_PIXELS;
            DIVIDER_PEN.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            DIVIDER_PEN.DashPattern = new float[2] { CAR_LENGTH_IN_PIXELS / 2f, 2f * CAR_LENGTH_IN_PIXELS };
            METERS_PER_PIXEL = TrafficSimulator.METERS_PER_PIXEL;
            METERS_PER_STRIPE = STRIDE_WIDTH_IN_PIXELS * METERS_PER_PIXEL;
            V_STRIDE = ROAD_H_IN_PIXELS + MEDIAN_H_IN_PIXELS;
            MAX_PASSING_COUNT = TrafficSimulator.PASSING_STEPS;
        }
        #endregion
    }
}
