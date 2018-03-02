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
            this.nudTimeSpeedup = new System.Windows.Forms.NumericUpDown();
            this.timeSpeedupLabel = new System.Windows.Forms.Label();
            this.nudTimeBetweenVehicles = new System.Windows.Forms.NumericUpDown();
            this.timeBetweenVehiclesLabel = new System.Windows.Forms.Label();
            this.nudTruckCarRatio = new System.Windows.Forms.NumericUpDown();
            this.truckCarRatioLabel = new System.Windows.Forms.Label();
            this.nudTimeVariability = new System.Windows.Forms.NumericUpDown();
            this.vehicleVariability = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.parameterGroupBox = new System.Windows.Forms.GroupBox();
            this.rdbMph = new System.Windows.Forms.RadioButton();
            this.rdbKmh = new System.Windows.Forms.RadioButton();
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
            this.lblTruckSpeedCappedUnit = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.roadblockLabel = new System.Windows.Forms.Label();
            this.nudSpeedVariability = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSpeedVariability = new System.Windows.Forms.Label();
            this.lblSpeedVariabilityRange = new System.Windows.Forms.Label();
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
            this.lblStripeLength = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblVehiclesExited = new System.Windows.Forms.Label();
            this.lblVehiclesOnRoad = new System.Windows.Forms.Label();
            this.lblRoadLengthUnit = new System.Windows.Forms.Label();
            this.lblStripeLengthUnit = new System.Windows.Forms.Label();
            this.lblRunTime = new System.Windows.Forms.Label();
            this.lblMaxSpeedUnit = new System.Windows.Forms.Label();
            this.lblMaxSpeed = new System.Windows.Forms.Label();
            this.lblAvgSpeedUnit = new System.Windows.Forms.Label();
            this.lblAveSpeed = new System.Windows.Forms.Label();
            this.lblMinSpeedUnit = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeSpeedup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeBetweenVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTruckCarRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeVariability)).BeginInit();
            this.parameterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTruckMaxSpeedVariability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTruckMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeedVariability)).BeginInit();
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
            // nudTimeSpeedup
            // 
            this.nudTimeSpeedup.DecimalPlaces = 2;
            this.nudTimeSpeedup.Enabled = false;
            this.nudTimeSpeedup.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudTimeSpeedup.Location = new System.Drawing.Point(130, 22);
            this.nudTimeSpeedup.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTimeSpeedup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudTimeSpeedup.Name = "nudTimeSpeedup";
            this.nudTimeSpeedup.Size = new System.Drawing.Size(50, 20);
            this.nudTimeSpeedup.TabIndex = 1;
            this.nudTimeSpeedup.Value = new decimal(new int[] {
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
            // nudTimeBetweenVehicles
            // 
            this.nudTimeBetweenVehicles.DecimalPlaces = 2;
            this.nudTimeBetweenVehicles.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTimeBetweenVehicles.Location = new System.Drawing.Point(130, 43);
            this.nudTimeBetweenVehicles.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTimeBetweenVehicles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTimeBetweenVehicles.Name = "nudTimeBetweenVehicles";
            this.nudTimeBetweenVehicles.Size = new System.Drawing.Size(50, 20);
            this.nudTimeBetweenVehicles.TabIndex = 1;
            this.nudTimeBetweenVehicles.Value = new decimal(new int[] {
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
            // nudTruckCarRatio
            // 
            this.nudTruckCarRatio.DecimalPlaces = 3;
            this.nudTruckCarRatio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudTruckCarRatio.Location = new System.Drawing.Point(130, 85);
            this.nudTruckCarRatio.Name = "nudTruckCarRatio";
            this.nudTruckCarRatio.Size = new System.Drawing.Size(50, 20);
            this.nudTruckCarRatio.TabIndex = 1;
            this.nudTruckCarRatio.Value = new decimal(new int[] {
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
            // nudTimeVariability
            // 
            this.nudTimeVariability.DecimalPlaces = 2;
            this.nudTimeVariability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTimeVariability.Location = new System.Drawing.Point(130, 64);
            this.nudTimeVariability.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTimeVariability.Name = "nudTimeVariability";
            this.nudTimeVariability.Size = new System.Drawing.Size(50, 20);
            this.nudTimeVariability.TabIndex = 1;
            this.nudTimeVariability.Value = new decimal(new int[] {
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
            this.parameterGroupBox.Controls.Add(this.rdbMph);
            this.parameterGroupBox.Controls.Add(this.rdbKmh);
            this.parameterGroupBox.Controls.Add(this.checkBox1);
            this.parameterGroupBox.Controls.Add(this.chkFixedTime);
            this.parameterGroupBox.Controls.Add(this.chkFixedSeed);
            this.parameterGroupBox.Controls.Add(this.chkPassOnRight);
            this.parameterGroupBox.Controls.Add(this.chkTruckMaxSpeed);
            this.parameterGroupBox.Controls.Add(this.chkRoadBlock);
            this.parameterGroupBox.Controls.Add(this.nudTimeSpeedup);
            this.parameterGroupBox.Controls.Add(this.nudTruckMaxSpeedVariability);
            this.parameterGroupBox.Controls.Add(this.nudTimeBetweenVehicles);
            this.parameterGroupBox.Controls.Add(this.nudTruckMaxSpeed);
            this.parameterGroupBox.Controls.Add(this.nudTruckCarRatio);
            this.parameterGroupBox.Controls.Add(this.label99);
            this.parameterGroupBox.Controls.Add(this.label14);
            this.parameterGroupBox.Controls.Add(this.label10);
            this.parameterGroupBox.Controls.Add(this.label25);
            this.parameterGroupBox.Controls.Add(this.lblTruckSpeedCappedUnit);
            this.parameterGroupBox.Controls.Add(this.label23);
            this.parameterGroupBox.Controls.Add(this.roadblockLabel);
            this.parameterGroupBox.Controls.Add(this.nudTimeVariability);
            this.parameterGroupBox.Controls.Add(this.nudSpeedVariability);
            this.parameterGroupBox.Controls.Add(this.label11);
            this.parameterGroupBox.Controls.Add(this.label2);
            this.parameterGroupBox.Controls.Add(this.timeSpeedupLabel);
            this.parameterGroupBox.Controls.Add(this.lblSpeedVariability);
            this.parameterGroupBox.Controls.Add(this.label3);
            this.parameterGroupBox.Controls.Add(this.vehicleVariability);
            this.parameterGroupBox.Controls.Add(this.label4);
            this.parameterGroupBox.Controls.Add(this.truckCarRatioLabel);
            this.parameterGroupBox.Controls.Add(this.label5);
            this.parameterGroupBox.Controls.Add(this.timeBetweenVehiclesLabel);
            this.parameterGroupBox.Controls.Add(this.label6);
            this.parameterGroupBox.Controls.Add(this.lblSpeedVariabilityRange);
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
            // rdbMph
            // 
            this.rdbMph.AutoSize = true;
            this.rdbMph.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbMph.Location = new System.Drawing.Point(579, 110);
            this.rdbMph.Name = "rdbMph";
            this.rdbMph.Size = new System.Drawing.Size(45, 17);
            this.rdbMph.TabIndex = 4;
            this.rdbMph.TabStop = true;
            this.rdbMph.Text = "mph";
            this.rdbMph.UseVisualStyleBackColor = true;
            this.rdbMph.CheckedChanged += new System.EventHandler(this.rdbSpeedUnit_CheckedChanged);
            // 
            // rdbKmh
            // 
            this.rdbKmh.AutoSize = true;
            this.rdbKmh.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbKmh.Checked = true;
            this.rdbKmh.Location = new System.Drawing.Point(513, 110);
            this.rdbKmh.Name = "rdbKmh";
            this.rdbKmh.Size = new System.Drawing.Size(50, 17);
            this.rdbKmh.TabIndex = 4;
            this.rdbKmh.TabStop = true;
            this.rdbKmh.Text = "km/h";
            this.rdbKmh.UseVisualStyleBackColor = true;
            this.rdbKmh.CheckedChanged += new System.EventHandler(this.rdbSpeedUnit_CheckedChanged);
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
            25,
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
            // lblTruckSpeedCappedUnit
            // 
            this.lblTruckSpeedCappedUnit.AutoSize = true;
            this.lblTruckSpeedCappedUnit.Location = new System.Drawing.Point(250, 108);
            this.lblTruckSpeedCappedUnit.Name = "lblTruckSpeedCappedUnit";
            this.lblTruckSpeedCappedUnit.Size = new System.Drawing.Size(32, 13);
            this.lblTruckSpeedCappedUnit.TabIndex = 0;
            this.lblTruckSpeedCappedUnit.Text = "km/h";
            this.lblTruckSpeedCappedUnit.Click += new System.EventHandler(this.rdbSpeedUnit_CheckedChanged);
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
            // nudSpeedVariability
            // 
            this.nudSpeedVariability.Location = new System.Drawing.Point(399, 22);
            this.nudSpeedVariability.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudSpeedVariability.Name = "nudSpeedVariability";
            this.nudSpeedVariability.Size = new System.Drawing.Size(50, 20);
            this.nudSpeedVariability.TabIndex = 1;
            this.nudSpeedVariability.Value = new decimal(new int[] {
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
            // lblSpeedVariability
            // 
            this.lblSpeedVariability.AutoSize = true;
            this.lblSpeedVariability.Location = new System.Drawing.Point(275, 26);
            this.lblSpeedVariability.Name = "lblSpeedVariability";
            this.lblSpeedVariability.Size = new System.Drawing.Size(118, 13);
            this.lblSpeedVariability.TabIndex = 2;
            this.lblSpeedVariability.Text = "Speed variability (km/h)";
            // 
            // lblSpeedVariabilityRange
            // 
            this.lblSpeedVariabilityRange.AutoSize = true;
            this.lblSpeedVariabilityRange.Location = new System.Drawing.Point(452, 24);
            this.lblSpeedVariabilityRange.Name = "lblSpeedVariabilityRange";
            this.lblSpeedVariabilityRange.Size = new System.Drawing.Size(40, 13);
            this.lblSpeedVariabilityRange.TabIndex = 2;
            this.lblSpeedVariabilityRange.Text = "0 ... 25";
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
            this.groupBox2.Controls.Add(this.lblStripeLength);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.aveSpeedLabel);
            this.groupBox2.Controls.Add(this.lblVehiclesExited);
            this.groupBox2.Controls.Add(this.lblVehiclesOnRoad);
            this.groupBox2.Controls.Add(this.lblRoadLengthUnit);
            this.groupBox2.Controls.Add(this.lblStripeLengthUnit);
            this.groupBox2.Controls.Add(this.lblRunTime);
            this.groupBox2.Controls.Add(this.lblMaxSpeedUnit);
            this.groupBox2.Controls.Add(this.lblMaxSpeed);
            this.groupBox2.Controls.Add(this.lblAvgSpeedUnit);
            this.groupBox2.Controls.Add(this.lblAveSpeed);
            this.groupBox2.Controls.Add(this.lblMinSpeedUnit);
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
            // lblStripeLength
            // 
            this.lblStripeLength.Location = new System.Drawing.Point(98, 26);
            this.lblStripeLength.Name = "lblStripeLength";
            this.lblStripeLength.Size = new System.Drawing.Size(35, 13);
            this.lblStripeLength.TabIndex = 0;
            this.lblStripeLength.Text = "---";
            this.lblStripeLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // lblRoadLengthUnit
            // 
            this.lblRoadLengthUnit.AutoSize = true;
            this.lblRoadLengthUnit.Location = new System.Drawing.Point(134, 46);
            this.lblRoadLengthUnit.Name = "lblRoadLengthUnit";
            this.lblRoadLengthUnit.Size = new System.Drawing.Size(21, 13);
            this.lblRoadLengthUnit.TabIndex = 0;
            this.lblRoadLengthUnit.Text = "km";
            // 
            // lblStripeLengthUnit
            // 
            this.lblStripeLengthUnit.AutoSize = true;
            this.lblStripeLengthUnit.Location = new System.Drawing.Point(134, 26);
            this.lblStripeLengthUnit.Name = "lblStripeLengthUnit";
            this.lblStripeLengthUnit.Size = new System.Drawing.Size(15, 13);
            this.lblStripeLengthUnit.TabIndex = 0;
            this.lblStripeLengthUnit.Text = "m";
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
            // lblMaxSpeedUnit
            // 
            this.lblMaxSpeedUnit.AutoSize = true;
            this.lblMaxSpeedUnit.Location = new System.Drawing.Point(291, 67);
            this.lblMaxSpeedUnit.Name = "lblMaxSpeedUnit";
            this.lblMaxSpeedUnit.Size = new System.Drawing.Size(32, 13);
            this.lblMaxSpeedUnit.TabIndex = 0;
            this.lblMaxSpeedUnit.Text = "km/h";
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
            // lblAvgSpeedUnit
            // 
            this.lblAvgSpeedUnit.AutoSize = true;
            this.lblAvgSpeedUnit.Location = new System.Drawing.Point(291, 47);
            this.lblAvgSpeedUnit.Name = "lblAvgSpeedUnit";
            this.lblAvgSpeedUnit.Size = new System.Drawing.Size(32, 13);
            this.lblAvgSpeedUnit.TabIndex = 0;
            this.lblAvgSpeedUnit.Text = "km/h";
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
            // lblMinSpeedUnit
            // 
            this.lblMinSpeedUnit.AutoSize = true;
            this.lblMinSpeedUnit.Location = new System.Drawing.Point(291, 26);
            this.lblMinSpeedUnit.Name = "lblMinSpeedUnit";
            this.lblMinSpeedUnit.Size = new System.Drawing.Size(32, 13);
            this.lblMinSpeedUnit.TabIndex = 0;
            this.lblMinSpeedUnit.Text = "km/h";
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
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnLoad);
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
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(115, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(115, 51);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // TrafficSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.parameterGroupBox);
            this.MaximizeBox = false;
            this.Name = "TrafficSimulator";
            this.Text = "Traffic Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.this_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeSpeedup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeBetweenVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTruckCarRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeVariability)).EndInit();
            this.parameterGroupBox.ResumeLayout(false);
            this.parameterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTruckMaxSpeedVariability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTruckMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeedVariability)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudTimeSpeedup;
        private System.Windows.Forms.Label timeSpeedupLabel;
        private System.Windows.Forms.NumericUpDown nudTimeBetweenVehicles;
        private System.Windows.Forms.Label timeBetweenVehiclesLabel;
        private System.Windows.Forms.NumericUpDown nudTruckCarRatio;
        private System.Windows.Forms.Label truckCarRatioLabel;
        private System.Windows.Forms.NumericUpDown nudTimeVariability;
        private System.Windows.Forms.Label vehicleVariability;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox parameterGroupBox;
        private System.Windows.Forms.Label lblMinSpeed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMinSpeedUnit;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label vehiclesOnRoadLabel;
        private System.Windows.Forms.Label lblStripeLength;
        private System.Windows.Forms.Label lblVehiclesOnRoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label roadblockLabel;
        private System.Windows.Forms.NumericUpDown nudSpeedVariability;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSpeedVariability;
        private System.Windows.Forms.Label lblSpeedVariabilityRange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudSpeederProbability;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudSlowPokeProbability;
        private System.Windows.Forms.CheckBox chkRoadBlock;
        private System.Windows.Forms.CheckBox chkPassOnRight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label vehiclesOffRoadLabel;
        private System.Windows.Forms.Label lblStripeLengthUnit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblRoadLength;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblMaxSpeedUnit;
        private System.Windows.Forms.Label lblMaxSpeed;
        private System.Windows.Forms.Label lblAvgSpeedUnit;
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
        private System.Windows.Forms.Label lblRoadLengthUnit;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkTruckMaxSpeed;
        private System.Windows.Forms.NumericUpDown nudTruckMaxSpeedVariability;
        private System.Windows.Forms.NumericUpDown nudTruckMaxSpeed;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblTruckSpeedCappedUnit;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RadioButton rdbMph;
        private System.Windows.Forms.RadioButton rdbKmh;
    }
}

