namespace Traffic
{
    partial class TrafficSimulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aveSpeedLabel = new System.Windows.Forms.Label();
            this.timeSpeedupUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeSpeedupLabel = new System.Windows.Forms.Label();
            this.timeBetweenVehiclesUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeBetweenVehiclesLabel = new System.Windows.Forms.Label();
            this.truckCarRatioUpDown = new System.Windows.Forms.NumericUpDown();
            this.truckCarRatioLabel = new System.Windows.Forms.Label();
            this.timeVariabilityUpDown = new System.Windows.Forms.NumericUpDown();
            this.vehicleVariability = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.parameterGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkFixedTime = new System.Windows.Forms.CheckBox();
            this.chkFixedSeed = new System.Windows.Forms.CheckBox();
            this.chkPassOnRight = new System.Windows.Forms.CheckBox();
            this.chkTruckMaxSpeed = new System.Windows.Forms.CheckBox();
            this.chkRoadBlock = new System.Windows.Forms.CheckBox();
            this.nudTruckMaxSpeedVariability = new System.Windows.Forms.NumericUpDown();
            this.nudTruckMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label99 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.roadblockLabel = new System.Windows.Forms.Label();
            this.speedVariability = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.speedVariabilityLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudSlowPokeProbability = new System.Windows.Forms.NumericUpDown();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.nudSpeederProbability = new System.Windows.Forms.NumericUpDown();
            this.lblMinSpeed = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.vehiclesOffRoadLabel = new System.Windows.Forms.Label();
            this.lblRoadLength = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.vehiclesOnRoadLabel = new System.Windows.Forms.Label();
            this.lblStripLength = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblVehiclesExited = new System.Windows.Forms.Label();
            this.lblVehiclesOnRoad = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRunTime = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblMaxSpeed = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblAveSpeed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpeedupUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBetweenVehiclesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckCarRatioUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeVariabilityUpDown)).BeginInit();
            this.parameterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTruckMaxSpeedVariability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTruckMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedVariability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlowPokeProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeederProbability)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aveSpeedLabel
            // 
            this.aveSpeedLabel.AutoSize = true;
            this.aveSpeedLabel.Location = new System.Drawing.Point(188, 25);
            this.aveSpeedLabel.Name = "aveSpeedLabel";
            this.aveSpeedLabel.Size = new System.Drawing.Size(56, 13);
            this.aveSpeedLabel.TabIndex = 0;
            this.aveSpeedLabel.Text = "Min speed";
            // 
            // timeSpeedupUpDown
            // 
            this.timeSpeedupUpDown.DecimalPlaces = 2;
            this.timeSpeedupUpDown.Enabled = false;
            this.timeSpeedupUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.timeSpeedupUpDown.Location = new System.Drawing.Point(130, 22);
            this.timeSpeedupUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timeSpeedupUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.timeSpeedupUpDown.Name = "timeSpeedupUpDown";
            this.timeSpeedupUpDown.Size = new System.Drawing.Size(50, 20);
            this.timeSpeedupUpDown.TabIndex = 1;
            this.timeSpeedupUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timeSpeedupLabel
            // 
            this.timeSpeedupLabel.AutoSize = true;
            this.timeSpeedupLabel.Location = new System.Drawing.Point(10, 26);
            this.timeSpeedupLabel.Name = "timeSpeedupLabel";
            this.timeSpeedupLabel.Size = new System.Drawing.Size(74, 13);
            this.timeSpeedupLabel.TabIndex = 2;
            this.timeSpeedupLabel.Text = "Time speedup";
            // 
            // timeBetweenVehiclesUpDown
            // 
            this.timeBetweenVehiclesUpDown.DecimalPlaces = 2;
            this.timeBetweenVehiclesUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.timeBetweenVehiclesUpDown.Location = new System.Drawing.Point(130, 43);
            this.timeBetweenVehiclesUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timeBetweenVehiclesUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.timeBetweenVehiclesUpDown.Name = "timeBetweenVehiclesUpDown";
            this.timeBetweenVehiclesUpDown.Size = new System.Drawing.Size(50, 20);
            this.timeBetweenVehiclesUpDown.TabIndex = 1;
            this.timeBetweenVehiclesUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // timeBetweenVehiclesLabel
            // 
            this.timeBetweenVehiclesLabel.AutoSize = true;
            this.timeBetweenVehiclesLabel.Location = new System.Drawing.Point(10, 47);
            this.timeBetweenVehiclesLabel.Name = "timeBetweenVehiclesLabel";
            this.timeBetweenVehiclesLabel.Size = new System.Drawing.Size(116, 13);
            this.timeBetweenVehiclesLabel.TabIndex = 2;
            this.timeBetweenVehiclesLabel.Text = "Time between vehicles";
            // 
            // truckCarRatioUpDown
            // 
            this.truckCarRatioUpDown.DecimalPlaces = 3;
            this.truckCarRatioUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.truckCarRatioUpDown.Location = new System.Drawing.Point(130, 85);
            this.truckCarRatioUpDown.Name = "truckCarRatioUpDown";
            this.truckCarRatioUpDown.Size = new System.Drawing.Size(50, 20);
            this.truckCarRatioUpDown.TabIndex = 1;
            this.truckCarRatioUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // truckCarRatioLabel
            // 
            this.truckCarRatioLabel.AutoSize = true;
            this.truckCarRatioLabel.Location = new System.Drawing.Point(10, 88);
            this.truckCarRatioLabel.Name = "truckCarRatioLabel";
            this.truckCarRatioLabel.Size = new System.Drawing.Size(78, 13);
            this.truckCarRatioLabel.TabIndex = 2;
            this.truckCarRatioLabel.Text = "Truck/car ratio";
            // 
            // timeVariabilityUpDown
            // 
            this.timeVariabilityUpDown.DecimalPlaces = 2;
            this.timeVariabilityUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.timeVariabilityUpDown.Location = new System.Drawing.Point(130, 64);
            this.timeVariabilityUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timeVariabilityUpDown.Name = "timeVariabilityUpDown";
            this.timeVariabilityUpDown.Size = new System.Drawing.Size(50, 20);
            this.timeVariabilityUpDown.TabIndex = 1;
            this.timeVariabilityUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // vehicleVariability
            // 
            this.vehicleVariability.AutoSize = true;
            this.vehicleVariability.Location = new System.Drawing.Point(10, 68);
            this.vehicleVariability.Name = "vehicleVariability";
            this.vehicleVariability.Size = new System.Drawing.Size(76, 13);
            this.vehicleVariability.TabIndex = 2;
            this.vehicleVariability.Text = "Time variability";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "0.01 .. 10 x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "0 ... 10 sec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "0 ... 10 sec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "0 ... 100";
            // 
            // parameterGroupBox
            // 
            this.parameterGroupBox.Controls.Add(this.checkBox1);
            this.parameterGroupBox.Controls.Add(this.chkFixedTime);
            this.parameterGroupBox.Controls.Add(this.chkFixedSeed);
            this.parameterGroupBox.Controls.Add(this.chkPassOnRight);
            this.parameterGroupBox.Controls.Add(this.chkTruckMaxSpeed);
            this.parameterGroupBox.Controls.Add(this.chkRoadBlock);
            this.parameterGroupBox.Controls.Add(this.timeSpeedupUpDown);
            this.parameterGroupBox.Controls.Add(this.nudTruckMaxSpeedVariability);
            this.parameterGroupBox.Controls.Add(this.timeBetweenVehiclesUpDown);
            this.parameterGroupBox.Controls.Add(this.nudTruckMaxSpeed);
            this.parameterGroupBox.Controls.Add(this.truckCarRatioUpDown);
            this.parameterGroupBox.Controls.Add(this.label99);
            this.parameterGroupBox.Controls.Add(this.label14);
            this.parameterGroupBox.Controls.Add(this.label10);
            this.parameterGroupBox.Controls.Add(this.label25);
            this.parameterGroupBox.Controls.Add(this.label26);
            this.parameterGroupBox.Controls.Add(this.label23);
            this.parameterGroupBox.Controls.Add(this.roadblockLabel);
            this.parameterGroupBox.Controls.Add(this.timeVariabilityUpDown);
            this.parameterGroupBox.Controls.Add(this.speedVariability);
            this.parameterGroupBox.Controls.Add(this.label11);
            this.parameterGroupBox.Controls.Add(this.label2);
            this.parameterGroupBox.Controls.Add(this.timeSpeedupLabel);
            this.parameterGroupBox.Controls.Add(this.speedVariabilityLabel);
            this.parameterGroupBox.Controls.Add(this.label3);
            this.parameterGroupBox.Controls.Add(this.vehicleVariability);
            this.parameterGroupBox.Controls.Add(this.label4);
            this.parameterGroupBox.Controls.Add(this.truckCarRatioLabel);
            this.parameterGroupBox.Controls.Add(this.label5);
            this.parameterGroupBox.Controls.Add(this.timeBetweenVehiclesLabel);
            this.parameterGroupBox.Controls.Add(this.label6);
            this.parameterGroupBox.Controls.Add(this.label7);
            this.parameterGroupBox.Controls.Add(this.label22);
            this.parameterGroupBox.Controls.Add(this.label21);
            this.parameterGroupBox.Controls.Add(this.label9);
            this.parameterGroupBox.Controls.Add(this.label8);
            this.parameterGroupBox.Controls.Add(this.nudSlowPokeProbability);
            this.parameterGroupBox.Controls.Add(this.nudSeconds);
            this.parameterGroupBox.Controls.Add(this.nudMinutes);
            this.parameterGroupBox.Controls.Add(this.nudSpeederProbability);
            this.parameterGroupBox.Location = new System.Drawing.Point(6, 4);
            this.parameterGroupBox.Name = "parameterGroupBox";
            this.parameterGroupBox.Size = new System.Drawing.Size(658, 133);
            this.parameterGroupBox.TabIndex = 4;
            this.parameterGroupBox.TabStop = false;
            this.parameterGroupBox.Text = "Parameters";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(673, 69);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkFixedTime
            // 
            this.chkFixedTime.AutoSize = true;
            this.chkFixedTime.Location = new System.Drawing.Point(611, 69);
            this.chkFixedTime.Name = "chkFixedTime";
            this.chkFixedTime.Size = new System.Drawing.Size(15, 14);
            this.chkFixedTime.TabIndex = 3;
            this.chkFixedTime.UseVisualStyleBackColor = true;
            // 
            // chkFixedSeed
            // 
            this.chkFixedSeed.AutoSize = true;
            this.chkFixedSeed.Location = new System.Drawing.Point(611, 47);
            this.chkFixedSeed.Name = "chkFixedSeed";
            this.chkFixedSeed.Size = new System.Drawing.Size(15, 14);
            this.chkFixedSeed.TabIndex = 3;
            this.chkFixedSeed.UseVisualStyleBackColor = true;
            // 
            // chkPassOnRight
            // 
            this.chkPassOnRight.AutoSize = true;
            this.chkPassOnRight.Location = new System.Drawing.Point(611, 24);
            this.chkPassOnRight.Name = "chkPassOnRight";
            this.chkPassOnRight.Size = new System.Drawing.Size(15, 14);
            this.chkPassOnRight.TabIndex = 3;
            this.chkPassOnRight.UseVisualStyleBackColor = true;
            // 
            // chkTruckMaxSpeed
            // 
            this.chkTruckMaxSpeed.AutoSize = true;
            this.chkTruckMaxSpeed.Location = new System.Drawing.Point(115, 108);
            this.chkTruckMaxSpeed.Name = "chkTruckMaxSpeed";
            this.chkTruckMaxSpeed.Size = new System.Drawing.Size(15, 14);
            this.chkTruckMaxSpeed.TabIndex = 3;
            this.chkTruckMaxSpeed.UseVisualStyleBackColor = true;
            this.chkTruckMaxSpeed.CheckedChanged += new System.EventHandler(this.chkRoadBlock_CheckedChanged);
            // 
            // chkRoadBlock
            // 
            this.chkRoadBlock.AutoSize = true;
            this.chkRoadBlock.Location = new System.Drawing.Point(399, 47);
            this.chkRoadBlock.Name = "chkRoadBlock";
            this.chkRoadBlock.Size = new System.Drawing.Size(15, 14);
            this.chkRoadBlock.TabIndex = 3;
            this.chkRoadBlock.UseVisualStyleBackColor = true;
            this.chkRoadBlock.CheckedChanged += new System.EventHandler(this.chkRoadBlock_CheckedChanged);
            // 
            // nudTruckMaxSpeedVariability
            // 
            this.nudTruckMaxSpeedVariability.DecimalPlaces = 1;
            this.nudTruckMaxSpeedVariability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTruckMaxSpeedVariability.Location = new System.Drawing.Point(202, 106);
            this.nudTruckMaxSpeedVariability.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudTruckMaxSpeedVariability.Name = "nudTruckMaxSpeedVariability";
            this.nudTruckMaxSpeedVariability.Size = new System.Drawing.Size(45, 20);
            this.nudTruckMaxSpeedVariability.TabIndex = 1;
            this.nudTruckMaxSpeedVariability.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudTruckMaxSpeed
            // 
            this.nudTruckMaxSpeed.Location = new System.Drawing.Point(130, 106);
            this.nudTruckMaxSpeed.Name = "nudTruckMaxSpeed";
            this.nudTruckMaxSpeed.Size = new System.Drawing.Size(50, 20);
            this.nudTruckMaxSpeed.TabIndex = 1;
            this.nudTruckMaxSpeed.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(509, 68);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(54, 13);
            this.label99.TabIndex = 2;
            this.label99.Text = "Fixed time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(509, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Fixed random seed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(509, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Pass on right";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(180, 108);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "+/-";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(250, 108);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(32, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "km/h";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 108);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Truck speed capped";
            // 
            // roadblockLabel
            // 
            this.roadblockLabel.AutoSize = true;
            this.roadblockLabel.Location = new System.Drawing.Point(275, 47);
            this.roadblockLabel.Name = "roadblockLabel";
            this.roadblockLabel.Size = new System.Drawing.Size(62, 13);
            this.roadblockLabel.TabIndex = 2;
            this.roadblockLabel.Text = "Road block";
            // 
            // speedVariability
            // 
            this.speedVariability.Location = new System.Drawing.Point(399, 22);
            this.speedVariability.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.speedVariability.Name = "speedVariability";
            this.speedVariability.Size = new System.Drawing.Size(50, 20);
            this.speedVariability.TabIndex = 1;
            this.speedVariability.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Slow poke probability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speeder probability";
            // 
            // speedVariabilityLabel
            // 
            this.speedVariabilityLabel.AutoSize = true;
            this.speedVariabilityLabel.Location = new System.Drawing.Point(275, 26);
            this.speedVariabilityLabel.Name = "speedVariabilityLabel";
            this.speedVariabilityLabel.Size = new System.Drawing.Size(118, 13);
            this.speedVariabilityLabel.TabIndex = 2;
            this.speedVariabilityLabel.Text = "Speed variability (km/h)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "0 ... 25";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(627, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "sec";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(560, 87);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "0 ... 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "0 ... 1";
            // 
            // nudSlowPokeProbability
            // 
            this.nudSlowPokeProbability.DecimalPlaces = 2;
            this.nudSlowPokeProbability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSlowPokeProbability.Location = new System.Drawing.Point(399, 85);
            this.nudSlowPokeProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSlowPokeProbability.Name = "nudSlowPokeProbability";
            this.nudSlowPokeProbability.Size = new System.Drawing.Size(50, 20);
            this.nudSlowPokeProbability.TabIndex = 1;
            this.nudSlowPokeProbability.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSlowPokeProbability.ValueChanged += new System.EventHandler(this.nudSlowPokeProbability_ValueChanged);
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(585, 85);
            this.nudSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(40, 20);
            this.nudSeconds.TabIndex = 1;
            this.nudSeconds.ValueChanged += new System.EventHandler(this.nudSpeederProbability_ValueChanged);
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(519, 85);
            this.nudMinutes.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(40, 20);
            this.nudMinutes.TabIndex = 1;
            this.nudMinutes.ValueChanged += new System.EventHandler(this.nudSpeederProbability_ValueChanged);
            // 
            // nudSpeederProbability
            // 
            this.nudSpeederProbability.DecimalPlaces = 2;
            this.nudSpeederProbability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSpeederProbability.Location = new System.Drawing.Point(399, 64);
            this.nudSpeederProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeederProbability.Name = "nudSpeederProbability";
            this.nudSpeederProbability.Size = new System.Drawing.Size(50, 20);
            this.nudSpeederProbability.TabIndex = 1;
            this.nudSpeederProbability.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudSpeederProbability.ValueChanged += new System.EventHandler(this.nudSpeederProbability_ValueChanged);
            // 
            // lblMinSpeed
            // 
            this.lblMinSpeed.Location = new System.Drawing.Point(252, 26);
            this.lblMinSpeed.Name = "lblMinSpeed";
            this.lblMinSpeed.Size = new System.Drawing.Size(35, 13);
            this.lblMinSpeed.TabIndex = 0;
            this.lblMinSpeed.Text = "---";
            this.lblMinSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.vehiclesOffRoadLabel);
            this.groupBox2.Controls.Add(this.lblRoadLength);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.vehiclesOnRoadLabel);
            this.groupBox2.Controls.Add(this.lblStripLength);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.aveSpeedLabel);
            this.groupBox2.Controls.Add(this.lblVehiclesExited);
            this.groupBox2.Controls.Add(this.lblVehiclesOnRoad);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblRunTime);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.lblMaxSpeed);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblAveSpeed);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblMinSpeed);
            this.groupBox2.Location = new System.Drawing.Point(670, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 135);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Road length";
            // 
            // vehiclesOffRoadLabel
            // 
            this.vehiclesOffRoadLabel.AutoSize = true;
            this.vehiclesOffRoadLabel.Location = new System.Drawing.Point(6, 25);
            this.vehiclesOffRoadLabel.Name = "vehiclesOffRoadLabel";
            this.vehiclesOffRoadLabel.Size = new System.Drawing.Size(66, 13);
            this.vehiclesOffRoadLabel.TabIndex = 0;
            this.vehiclesOffRoadLabel.Text = "Stripe length";
            // 
            // lblRoadLength
            // 
            this.lblRoadLength.Location = new System.Drawing.Point(98, 46);
            this.lblRoadLength.Name = "lblRoadLength";
            this.lblRoadLength.Size = new System.Drawing.Size(35, 13);
            this.lblRoadLength.TabIndex = 0;
            this.lblRoadLength.Text = "---";
            this.lblRoadLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Vehicles exited";
            // 
            // vehiclesOnRoadLabel
            // 
            this.vehiclesOnRoadLabel.AutoSize = true;
            this.vehiclesOnRoadLabel.Location = new System.Drawing.Point(6, 66);
            this.vehiclesOnRoadLabel.Name = "vehiclesOnRoadLabel";
            this.vehiclesOnRoadLabel.Size = new System.Drawing.Size(86, 13);
            this.vehiclesOnRoadLabel.TabIndex = 0;
            this.vehiclesOnRoadLabel.Text = "Vehicles on road";
            // 
            // lblStripLength
            // 
            this.lblStripLength.Location = new System.Drawing.Point(98, 26);
            this.lblStripLength.Name = "lblStripLength";
            this.lblStripLength.Size = new System.Drawing.Size(35, 13);
            this.lblStripLength.TabIndex = 0;
            this.lblStripLength.Text = "---";
            this.lblStripLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(188, 86);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Run time";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(188, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Max speed";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(188, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Avg speed";
            // 
            // lblVehiclesExited
            // 
            this.lblVehiclesExited.Location = new System.Drawing.Point(98, 87);
            this.lblVehiclesExited.Name = "lblVehiclesExited";
            this.lblVehiclesExited.Size = new System.Drawing.Size(35, 13);
            this.lblVehiclesExited.TabIndex = 0;
            this.lblVehiclesExited.Text = "0";
            this.lblVehiclesExited.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVehiclesOnRoad
            // 
            this.lblVehiclesOnRoad.Location = new System.Drawing.Point(98, 67);
            this.lblVehiclesOnRoad.Name = "lblVehiclesOnRoad";
            this.lblVehiclesOnRoad.Size = new System.Drawing.Size(35, 13);
            this.lblVehiclesOnRoad.TabIndex = 0;
            this.lblVehiclesOnRoad.Text = "0";
            this.lblVehiclesOnRoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(134, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "km";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(134, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "m";
            // 
            // lblRunTime
            // 
            this.lblRunTime.Location = new System.Drawing.Point(237, 83);
            this.lblRunTime.Name = "lblRunTime";
            this.lblRunTime.Size = new System.Drawing.Size(50, 19);
            this.lblRunTime.TabIndex = 0;
            this.lblRunTime.Text = "---";
            this.lblRunTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(291, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "km/h";
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.Location = new System.Drawing.Point(252, 67);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(35, 13);
            this.lblMaxSpeed.TabIndex = 0;
            this.lblMaxSpeed.Text = "---";
            this.lblMaxSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(291, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "km/h";
            // 
            // lblAveSpeed
            // 
            this.lblAveSpeed.Location = new System.Drawing.Point(252, 47);
            this.lblAveSpeed.Name = "lblAveSpeed";
            this.lblAveSpeed.Size = new System.Drawing.Size(35, 13);
            this.lblAveSpeed.TabIndex = 0;
            this.lblAveSpeed.Text = "---";
            this.lblAveSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "km/h";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(20, 50);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(20, 78);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.loadButton);
            this.groupBox1.Location = new System.Drawing.Point(1008, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(115, 79);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(115, 22);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Enabled = false;
            this.loadButton.Location = new System.Drawing.Point(115, 51);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // TrafficSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.parameterGroupBox);
            this.Name = "TrafficSimulator";
            this.Text = "Traffic Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.timeSpeedupUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBetweenVehiclesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckCarRatioUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeVariabilityUpDown)).EndInit();
            this.parameterGroupBox.ResumeLayout(false);
            this.parameterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTruckMaxSpeedVariability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTruckMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedVariability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlowPokeProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeederProbability)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label aveSpeedLabel;
        private System.Windows.Forms.NumericUpDown timeSpeedupUpDown;
        private System.Windows.Forms.Label timeSpeedupLabel;
        private System.Windows.Forms.NumericUpDown timeBetweenVehiclesUpDown;
        private System.Windows.Forms.Label timeBetweenVehiclesLabel;
        private System.Windows.Forms.NumericUpDown truckCarRatioUpDown;
        private System.Windows.Forms.Label truckCarRatioLabel;
        private System.Windows.Forms.NumericUpDown timeVariabilityUpDown;
        private System.Windows.Forms.Label vehicleVariability;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox parameterGroupBox;
        private System.Windows.Forms.Label lblMinSpeed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label vehiclesOnRoadLabel;
        private System.Windows.Forms.Label lblStripLength;
        private System.Windows.Forms.Label lblVehiclesOnRoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label roadblockLabel;
        private System.Windows.Forms.NumericUpDown speedVariability;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label speedVariabilityLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudSpeederProbability;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudSlowPokeProbability;
        private System.Windows.Forms.CheckBox chkRoadBlock;
        private System.Windows.Forms.CheckBox chkPassOnRight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label vehiclesOffRoadLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblRoadLength;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblMaxSpeed;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblAveSpeed;
        private System.Windows.Forms.CheckBox chkFixedSeed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblVehiclesExited;
        private System.Windows.Forms.CheckBox chkFixedTime;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblRunTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkTruckMaxSpeed;
        private System.Windows.Forms.NumericUpDown nudTruckMaxSpeedVariability;
        private System.Windows.Forms.NumericUpDown nudTruckMaxSpeed;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
    }
}

