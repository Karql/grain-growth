namespace grain_growth
{
    partial class MainForm
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
            this.PB = new System.Windows.Forms.PictureBox();
            this.gridGroupBox = new System.Windows.Forms.GroupBox();
            this.gridZoomLabel = new System.Windows.Forms.Label();
            this.gridZoomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gridPeriodicLabel = new System.Windows.Forms.Label();
            this.gridPeriodicCheckBox = new System.Windows.Forms.CheckBox();
            this.gridWidthLabel = new System.Windows.Forms.Label();
            this.gridWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gridHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gridHeightLabel = new System.Windows.Forms.Label();
            this.inclusionsGroupBox = new System.Windows.Forms.GroupBox();
            this.inclusionCircleButton = new System.Windows.Forms.Button();
            this.inclusionSquareButton = new System.Windows.Forms.Button();
            this.inclusionRadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inclusionRadiusLabel = new System.Windows.Forms.Label();
            this.caGroupBox = new System.Windows.Forms.GroupBox();
            this.caNeighborhoodComboBox = new System.Windows.Forms.ComboBox();
            this.caNeighborhoodLabel = new System.Windows.Forms.Label();
            this.caSimulateButton = new System.Windows.Forms.Button();
            this.caAddRandomGrainsButton = new System.Windows.Forms.Button();
            this.caGrainsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.caGrainsLabel = new System.Windows.Forms.Label();
            this.mcGroupBox = new System.Windows.Forms.GroupBox();
            this.mcStepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mcStepsLabel = new System.Windows.Forms.Label();
            this.mcNeighborhoodComboBox = new System.Windows.Forms.ComboBox();
            this.mcSimulateButton = new System.Windows.Forms.Button();
            this.mcNeighborhoodLabel = new System.Windows.Forms.Label();
            this.mcInitRandomGrainsButton = new System.Windows.Forms.Button();
            this.mcGrainsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mcGrainsLabel = new System.Windows.Forms.Label();
            this.dpGroupBox = new System.Windows.Forms.GroupBox();
            this.dpSelectButton = new System.Windows.Forms.Button();
            this.dpChangeIdCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.srxGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.srxAddTimesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.srxSimulateButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.srxStepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.srxAddEveryStepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.srxNucleationsDiffNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.srxNucleationsAtStartNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.srxNucleationsAdditionsComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.srxEnergyValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.srxEnergyDistributionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.srxHighlightRecrystalizedCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.gridGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridZoomNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeightNumericUpDown)).BeginInit();
            this.inclusionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inclusionRadiusNumericUpDown)).BeginInit();
            this.caGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caGrainsNumericUpDown)).BeginInit();
            this.mcGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mcStepsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcGrainsNumericUpDown)).BeginInit();
            this.dpGroupBox.SuspendLayout();
            this.srxGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srxAddTimesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxStepsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxAddEveryStepsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxNucleationsDiffNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxNucleationsAtStartNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxEnergyValueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PB
            // 
            this.PB.BackColor = System.Drawing.Color.White;
            this.PB.Location = new System.Drawing.Point(12, 137);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(100, 100);
            this.PB.TabIndex = 0;
            this.PB.TabStop = false;
            this.PB.Click += new System.EventHandler(this.PB_Click);
            this.PB.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_Paint);
            // 
            // gridGroupBox
            // 
            this.gridGroupBox.Controls.Add(this.gridZoomLabel);
            this.gridGroupBox.Controls.Add(this.gridZoomNumericUpDown);
            this.gridGroupBox.Controls.Add(this.gridPeriodicLabel);
            this.gridGroupBox.Controls.Add(this.gridPeriodicCheckBox);
            this.gridGroupBox.Controls.Add(this.gridWidthLabel);
            this.gridGroupBox.Controls.Add(this.gridWidthNumericUpDown);
            this.gridGroupBox.Controls.Add(this.gridHeightNumericUpDown);
            this.gridGroupBox.Controls.Add(this.gridHeightLabel);
            this.gridGroupBox.Location = new System.Drawing.Point(12, 12);
            this.gridGroupBox.Name = "gridGroupBox";
            this.gridGroupBox.Size = new System.Drawing.Size(131, 119);
            this.gridGroupBox.TabIndex = 4;
            this.gridGroupBox.TabStop = false;
            this.gridGroupBox.Text = "Grid";
            // 
            // gridZoomLabel
            // 
            this.gridZoomLabel.AutoSize = true;
            this.gridZoomLabel.Location = new System.Drawing.Point(6, 73);
            this.gridZoomLabel.Name = "gridZoomLabel";
            this.gridZoomLabel.Size = new System.Drawing.Size(37, 13);
            this.gridZoomLabel.TabIndex = 7;
            this.gridZoomLabel.Text = "Zoom:";
            // 
            // gridZoomNumericUpDown
            // 
            this.gridZoomNumericUpDown.Location = new System.Drawing.Point(60, 71);
            this.gridZoomNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.gridZoomNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gridZoomNumericUpDown.Name = "gridZoomNumericUpDown";
            this.gridZoomNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.gridZoomNumericUpDown.TabIndex = 6;
            this.gridZoomNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gridZoomNumericUpDown.ValueChanged += new System.EventHandler(this.gridZoomNumericUpDown_ValueChanged);
            // 
            // gridPeriodicLabel
            // 
            this.gridPeriodicLabel.AutoSize = true;
            this.gridPeriodicLabel.Location = new System.Drawing.Point(6, 97);
            this.gridPeriodicLabel.Name = "gridPeriodicLabel";
            this.gridPeriodicLabel.Size = new System.Drawing.Size(48, 13);
            this.gridPeriodicLabel.TabIndex = 5;
            this.gridPeriodicLabel.Text = "Periodic:";
            // 
            // gridPeriodicCheckBox
            // 
            this.gridPeriodicCheckBox.AutoSize = true;
            this.gridPeriodicCheckBox.Checked = true;
            this.gridPeriodicCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridPeriodicCheckBox.Location = new System.Drawing.Point(60, 97);
            this.gridPeriodicCheckBox.Name = "gridPeriodicCheckBox";
            this.gridPeriodicCheckBox.Size = new System.Drawing.Size(15, 14);
            this.gridPeriodicCheckBox.TabIndex = 4;
            this.gridPeriodicCheckBox.UseVisualStyleBackColor = true;
            // 
            // gridWidthLabel
            // 
            this.gridWidthLabel.AutoSize = true;
            this.gridWidthLabel.Location = new System.Drawing.Point(6, 47);
            this.gridWidthLabel.Name = "gridWidthLabel";
            this.gridWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.gridWidthLabel.TabIndex = 3;
            this.gridWidthLabel.Text = "Width:";
            // 
            // gridWidthNumericUpDown
            // 
            this.gridWidthNumericUpDown.Location = new System.Drawing.Point(60, 45);
            this.gridWidthNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.gridWidthNumericUpDown.Name = "gridWidthNumericUpDown";
            this.gridWidthNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.gridWidthNumericUpDown.TabIndex = 2;
            this.gridWidthNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.gridWidthNumericUpDown.ValueChanged += new System.EventHandler(this.girdProperties_Changed);
            // 
            // gridHeightNumericUpDown
            // 
            this.gridHeightNumericUpDown.Location = new System.Drawing.Point(60, 19);
            this.gridHeightNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.gridHeightNumericUpDown.Name = "gridHeightNumericUpDown";
            this.gridHeightNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.gridHeightNumericUpDown.TabIndex = 1;
            this.gridHeightNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.gridHeightNumericUpDown.ValueChanged += new System.EventHandler(this.girdProperties_Changed);
            // 
            // gridHeightLabel
            // 
            this.gridHeightLabel.AutoSize = true;
            this.gridHeightLabel.Location = new System.Drawing.Point(6, 21);
            this.gridHeightLabel.Name = "gridHeightLabel";
            this.gridHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.gridHeightLabel.TabIndex = 0;
            this.gridHeightLabel.Text = "Height:";
            // 
            // inclusionsGroupBox
            // 
            this.inclusionsGroupBox.Controls.Add(this.inclusionCircleButton);
            this.inclusionsGroupBox.Controls.Add(this.inclusionSquareButton);
            this.inclusionsGroupBox.Controls.Add(this.inclusionRadiusNumericUpDown);
            this.inclusionsGroupBox.Controls.Add(this.inclusionRadiusLabel);
            this.inclusionsGroupBox.Location = new System.Drawing.Point(149, 12);
            this.inclusionsGroupBox.Name = "inclusionsGroupBox";
            this.inclusionsGroupBox.Size = new System.Drawing.Size(128, 119);
            this.inclusionsGroupBox.TabIndex = 5;
            this.inclusionsGroupBox.TabStop = false;
            this.inclusionsGroupBox.Text = "Inclusions";
            // 
            // inclusionCircleButton
            // 
            this.inclusionCircleButton.BackColor = System.Drawing.SystemColors.Control;
            this.inclusionCircleButton.Location = new System.Drawing.Point(9, 74);
            this.inclusionCircleButton.Name = "inclusionCircleButton";
            this.inclusionCircleButton.Size = new System.Drawing.Size(106, 23);
            this.inclusionCircleButton.TabIndex = 10;
            this.inclusionCircleButton.Text = "Circle";
            this.inclusionCircleButton.UseVisualStyleBackColor = false;
            this.inclusionCircleButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // inclusionSquareButton
            // 
            this.inclusionSquareButton.Location = new System.Drawing.Point(9, 45);
            this.inclusionSquareButton.Name = "inclusionSquareButton";
            this.inclusionSquareButton.Size = new System.Drawing.Size(106, 23);
            this.inclusionSquareButton.TabIndex = 9;
            this.inclusionSquareButton.Text = "Square";
            this.inclusionSquareButton.UseVisualStyleBackColor = false;
            this.inclusionSquareButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // inclusionRadiusNumericUpDown
            // 
            this.inclusionRadiusNumericUpDown.Location = new System.Drawing.Point(55, 19);
            this.inclusionRadiusNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.inclusionRadiusNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inclusionRadiusNumericUpDown.Name = "inclusionRadiusNumericUpDown";
            this.inclusionRadiusNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.inclusionRadiusNumericUpDown.TabIndex = 8;
            this.inclusionRadiusNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // inclusionRadiusLabel
            // 
            this.inclusionRadiusLabel.AutoSize = true;
            this.inclusionRadiusLabel.Location = new System.Drawing.Point(6, 21);
            this.inclusionRadiusLabel.Name = "inclusionRadiusLabel";
            this.inclusionRadiusLabel.Size = new System.Drawing.Size(43, 13);
            this.inclusionRadiusLabel.TabIndex = 0;
            this.inclusionRadiusLabel.Text = "Radius:";
            // 
            // caGroupBox
            // 
            this.caGroupBox.Controls.Add(this.caNeighborhoodComboBox);
            this.caGroupBox.Controls.Add(this.caNeighborhoodLabel);
            this.caGroupBox.Controls.Add(this.caSimulateButton);
            this.caGroupBox.Controls.Add(this.caAddRandomGrainsButton);
            this.caGroupBox.Controls.Add(this.caGrainsNumericUpDown);
            this.caGroupBox.Controls.Add(this.caGrainsLabel);
            this.caGroupBox.Location = new System.Drawing.Point(283, 11);
            this.caGroupBox.Name = "caGroupBox";
            this.caGroupBox.Size = new System.Drawing.Size(189, 120);
            this.caGroupBox.TabIndex = 6;
            this.caGroupBox.TabStop = false;
            this.caGroupBox.Text = "CA";
            // 
            // caNeighborhoodComboBox
            // 
            this.caNeighborhoodComboBox.FormattingEnabled = true;
            this.caNeighborhoodComboBox.Items.AddRange(new object[] {
            "Moorea\'a",
            "Von Neumann\'a",
            "Hex Random",
            "Penta Random",
            "Further Moor"});
            this.caNeighborhoodComboBox.Location = new System.Drawing.Point(98, 48);
            this.caNeighborhoodComboBox.Name = "caNeighborhoodComboBox";
            this.caNeighborhoodComboBox.Size = new System.Drawing.Size(83, 21);
            this.caNeighborhoodComboBox.TabIndex = 5;
            // 
            // caNeighborhoodLabel
            // 
            this.caNeighborhoodLabel.AutoSize = true;
            this.caNeighborhoodLabel.Location = new System.Drawing.Point(6, 48);
            this.caNeighborhoodLabel.Name = "caNeighborhoodLabel";
            this.caNeighborhoodLabel.Size = new System.Drawing.Size(77, 13);
            this.caNeighborhoodLabel.TabIndex = 4;
            this.caNeighborhoodLabel.Text = "Neighborhood:";
            // 
            // caSimulateButton
            // 
            this.caSimulateButton.Location = new System.Drawing.Point(9, 75);
            this.caSimulateButton.Name = "caSimulateButton";
            this.caSimulateButton.Size = new System.Drawing.Size(83, 23);
            this.caSimulateButton.TabIndex = 3;
            this.caSimulateButton.Text = "Simulate";
            this.caSimulateButton.UseVisualStyleBackColor = true;
            this.caSimulateButton.Click += new System.EventHandler(this.caSimulateButton_Click);
            // 
            // caAddRandomGrainsButton
            // 
            this.caAddRandomGrainsButton.Location = new System.Drawing.Point(98, 17);
            this.caAddRandomGrainsButton.Name = "caAddRandomGrainsButton";
            this.caAddRandomGrainsButton.Size = new System.Drawing.Size(83, 23);
            this.caAddRandomGrainsButton.TabIndex = 2;
            this.caAddRandomGrainsButton.Text = "Add";
            this.caAddRandomGrainsButton.UseVisualStyleBackColor = true;
            this.caAddRandomGrainsButton.Click += new System.EventHandler(this.caAddRandomGrainsButton_Click);
            // 
            // caGrainsNumericUpDown
            // 
            this.caGrainsNumericUpDown.Location = new System.Drawing.Point(52, 20);
            this.caGrainsNumericUpDown.Name = "caGrainsNumericUpDown";
            this.caGrainsNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.caGrainsNumericUpDown.TabIndex = 1;
            this.caGrainsNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // caGrainsLabel
            // 
            this.caGrainsLabel.AutoSize = true;
            this.caGrainsLabel.Location = new System.Drawing.Point(6, 22);
            this.caGrainsLabel.Name = "caGrainsLabel";
            this.caGrainsLabel.Size = new System.Drawing.Size(40, 13);
            this.caGrainsLabel.TabIndex = 0;
            this.caGrainsLabel.Text = "Grains:";
            // 
            // mcGroupBox
            // 
            this.mcGroupBox.Controls.Add(this.mcStepsNumericUpDown);
            this.mcGroupBox.Controls.Add(this.mcStepsLabel);
            this.mcGroupBox.Controls.Add(this.mcNeighborhoodComboBox);
            this.mcGroupBox.Controls.Add(this.mcSimulateButton);
            this.mcGroupBox.Controls.Add(this.mcNeighborhoodLabel);
            this.mcGroupBox.Controls.Add(this.mcInitRandomGrainsButton);
            this.mcGroupBox.Controls.Add(this.mcGrainsNumericUpDown);
            this.mcGroupBox.Controls.Add(this.mcGrainsLabel);
            this.mcGroupBox.Location = new System.Drawing.Point(478, 11);
            this.mcGroupBox.Name = "mcGroupBox";
            this.mcGroupBox.Size = new System.Drawing.Size(189, 120);
            this.mcGroupBox.TabIndex = 7;
            this.mcGroupBox.TabStop = false;
            this.mcGroupBox.Text = "MC";
            // 
            // mcStepsNumericUpDown
            // 
            this.mcStepsNumericUpDown.Location = new System.Drawing.Point(52, 77);
            this.mcStepsNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.mcStepsNumericUpDown.Name = "mcStepsNumericUpDown";
            this.mcStepsNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.mcStepsNumericUpDown.TabIndex = 7;
            this.mcStepsNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // mcStepsLabel
            // 
            this.mcStepsLabel.AutoSize = true;
            this.mcStepsLabel.Location = new System.Drawing.Point(6, 80);
            this.mcStepsLabel.Name = "mcStepsLabel";
            this.mcStepsLabel.Size = new System.Drawing.Size(37, 13);
            this.mcStepsLabel.TabIndex = 6;
            this.mcStepsLabel.Text = "Steps:";
            // 
            // mcNeighborhoodComboBox
            // 
            this.mcNeighborhoodComboBox.FormattingEnabled = true;
            this.mcNeighborhoodComboBox.Items.AddRange(new object[] {
            "Moorea\'a",
            "Von Neumann\'a",
            "Hex Random",
            "Penta Random",
            "Further Moor"});
            this.mcNeighborhoodComboBox.Location = new System.Drawing.Point(98, 48);
            this.mcNeighborhoodComboBox.Name = "mcNeighborhoodComboBox";
            this.mcNeighborhoodComboBox.Size = new System.Drawing.Size(83, 21);
            this.mcNeighborhoodComboBox.TabIndex = 5;
            // 
            // mcSimulateButton
            // 
            this.mcSimulateButton.Location = new System.Drawing.Point(98, 74);
            this.mcSimulateButton.Name = "mcSimulateButton";
            this.mcSimulateButton.Size = new System.Drawing.Size(83, 23);
            this.mcSimulateButton.TabIndex = 3;
            this.mcSimulateButton.Text = "Simulate";
            this.mcSimulateButton.UseVisualStyleBackColor = true;
            this.mcSimulateButton.Click += new System.EventHandler(this.mcSimulateButton_Click);
            // 
            // mcNeighborhoodLabel
            // 
            this.mcNeighborhoodLabel.AutoSize = true;
            this.mcNeighborhoodLabel.Location = new System.Drawing.Point(6, 48);
            this.mcNeighborhoodLabel.Name = "mcNeighborhoodLabel";
            this.mcNeighborhoodLabel.Size = new System.Drawing.Size(77, 13);
            this.mcNeighborhoodLabel.TabIndex = 4;
            this.mcNeighborhoodLabel.Text = "Neighborhood:";
            // 
            // mcInitRandomGrainsButton
            // 
            this.mcInitRandomGrainsButton.Location = new System.Drawing.Point(98, 17);
            this.mcInitRandomGrainsButton.Name = "mcInitRandomGrainsButton";
            this.mcInitRandomGrainsButton.Size = new System.Drawing.Size(83, 23);
            this.mcInitRandomGrainsButton.TabIndex = 2;
            this.mcInitRandomGrainsButton.Text = "Init";
            this.mcInitRandomGrainsButton.UseVisualStyleBackColor = true;
            this.mcInitRandomGrainsButton.Click += new System.EventHandler(this.mcInitRandomGrainsButton_Click);
            // 
            // mcGrainsNumericUpDown
            // 
            this.mcGrainsNumericUpDown.Location = new System.Drawing.Point(52, 20);
            this.mcGrainsNumericUpDown.Name = "mcGrainsNumericUpDown";
            this.mcGrainsNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.mcGrainsNumericUpDown.TabIndex = 1;
            this.mcGrainsNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // mcGrainsLabel
            // 
            this.mcGrainsLabel.AutoSize = true;
            this.mcGrainsLabel.Location = new System.Drawing.Point(6, 22);
            this.mcGrainsLabel.Name = "mcGrainsLabel";
            this.mcGrainsLabel.Size = new System.Drawing.Size(40, 13);
            this.mcGrainsLabel.TabIndex = 0;
            this.mcGrainsLabel.Text = "Grains:";
            // 
            // dpGroupBox
            // 
            this.dpGroupBox.Controls.Add(this.dpSelectButton);
            this.dpGroupBox.Controls.Add(this.dpChangeIdCheckBox);
            this.dpGroupBox.Controls.Add(this.label1);
            this.dpGroupBox.Location = new System.Drawing.Point(673, 11);
            this.dpGroupBox.Name = "dpGroupBox";
            this.dpGroupBox.Size = new System.Drawing.Size(92, 120);
            this.dpGroupBox.TabIndex = 8;
            this.dpGroupBox.TabStop = false;
            this.dpGroupBox.Text = "Dual Phase";
            // 
            // dpSelectButton
            // 
            this.dpSelectButton.BackColor = System.Drawing.SystemColors.Control;
            this.dpSelectButton.Location = new System.Drawing.Point(9, 46);
            this.dpSelectButton.Name = "dpSelectButton";
            this.dpSelectButton.Size = new System.Drawing.Size(76, 23);
            this.dpSelectButton.TabIndex = 2;
            this.dpSelectButton.Text = "Select";
            this.dpSelectButton.UseVisualStyleBackColor = false;
            this.dpSelectButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // dpChangeIdCheckBox
            // 
            this.dpChangeIdCheckBox.AutoSize = true;
            this.dpChangeIdCheckBox.Checked = true;
            this.dpChangeIdCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dpChangeIdCheckBox.Location = new System.Drawing.Point(70, 21);
            this.dpChangeIdCheckBox.Name = "dpChangeIdCheckBox";
            this.dpChangeIdCheckBox.Size = new System.Drawing.Size(15, 14);
            this.dpChangeIdCheckBox.TabIndex = 1;
            this.dpChangeIdCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change id:";
            // 
            // srxGroupBox
            // 
            this.srxGroupBox.Controls.Add(this.srxHighlightRecrystalizedCheckBox);
            this.srxGroupBox.Controls.Add(this.label10);
            this.srxGroupBox.Controls.Add(this.label9);
            this.srxGroupBox.Controls.Add(this.srxAddTimesNumericUpDown);
            this.srxGroupBox.Controls.Add(this.srxSimulateButton);
            this.srxGroupBox.Controls.Add(this.label8);
            this.srxGroupBox.Controls.Add(this.srxStepsNumericUpDown);
            this.srxGroupBox.Controls.Add(this.label7);
            this.srxGroupBox.Controls.Add(this.srxAddEveryStepsNumericUpDown);
            this.srxGroupBox.Controls.Add(this.label6);
            this.srxGroupBox.Controls.Add(this.srxNucleationsDiffNumericUpDown);
            this.srxGroupBox.Controls.Add(this.label5);
            this.srxGroupBox.Controls.Add(this.srxNucleationsAtStartNumericUpDown);
            this.srxGroupBox.Controls.Add(this.srxNucleationsAdditionsComboBox);
            this.srxGroupBox.Controls.Add(this.label4);
            this.srxGroupBox.Controls.Add(this.srxEnergyValueNumericUpDown);
            this.srxGroupBox.Controls.Add(this.label3);
            this.srxGroupBox.Controls.Add(this.srxEnergyDistributionComboBox);
            this.srxGroupBox.Controls.Add(this.label2);
            this.srxGroupBox.Location = new System.Drawing.Point(478, 137);
            this.srxGroupBox.Name = "srxGroupBox";
            this.srxGroupBox.Size = new System.Drawing.Size(287, 326);
            this.srxGroupBox.TabIndex = 12;
            this.srxGroupBox.TabStop = false;
            this.srxGroupBox.Text = "SRX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Add times";
            // 
            // srxAddTimesNumericUpDown
            // 
            this.srxAddTimesNumericUpDown.Location = new System.Drawing.Point(123, 190);
            this.srxAddTimesNumericUpDown.Name = "srxAddTimesNumericUpDown";
            this.srxAddTimesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.srxAddTimesNumericUpDown.TabIndex = 17;
            this.srxAddTimesNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // srxSimulateButton
            // 
            this.srxSimulateButton.Location = new System.Drawing.Point(9, 285);
            this.srxSimulateButton.Name = "srxSimulateButton";
            this.srxSimulateButton.Size = new System.Drawing.Size(75, 23);
            this.srxSimulateButton.TabIndex = 16;
            this.srxSimulateButton.Text = "Simulate";
            this.srxSimulateButton.UseVisualStyleBackColor = true;
            this.srxSimulateButton.Click += new System.EventHandler(this.srxSimulateButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "SRX steeps:";
            // 
            // srxStepsNumericUpDown
            // 
            this.srxStepsNumericUpDown.Location = new System.Drawing.Point(123, 227);
            this.srxStepsNumericUpDown.Name = "srxStepsNumericUpDown";
            this.srxStepsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.srxStepsNumericUpDown.TabIndex = 14;
            this.srxStepsNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Add every steps:";
            // 
            // srxAddEveryStepsNumericUpDown
            // 
            this.srxAddEveryStepsNumericUpDown.Location = new System.Drawing.Point(123, 163);
            this.srxAddEveryStepsNumericUpDown.Name = "srxAddEveryStepsNumericUpDown";
            this.srxAddEveryStepsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.srxAddEveryStepsNumericUpDown.TabIndex = 12;
            this.srxAddEveryStepsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nucleations diff:";
            // 
            // srxNucleationsDiffNumericUpDown
            // 
            this.srxNucleationsDiffNumericUpDown.Location = new System.Drawing.Point(123, 137);
            this.srxNucleationsDiffNumericUpDown.Name = "srxNucleationsDiffNumericUpDown";
            this.srxNucleationsDiffNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.srxNucleationsDiffNumericUpDown.TabIndex = 10;
            this.srxNucleationsDiffNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nucleations at start:";
            // 
            // srxNucleationsAtStartNumericUpDown
            // 
            this.srxNucleationsAtStartNumericUpDown.Location = new System.Drawing.Point(123, 111);
            this.srxNucleationsAtStartNumericUpDown.Name = "srxNucleationsAtStartNumericUpDown";
            this.srxNucleationsAtStartNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.srxNucleationsAtStartNumericUpDown.TabIndex = 8;
            this.srxNucleationsAtStartNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // srxNucleationsAdditionsComboBox
            // 
            this.srxNucleationsAdditionsComboBox.FormattingEnabled = true;
            this.srxNucleationsAdditionsComboBox.Items.AddRange(new object[] {
            "At beggining",
            "Constant",
            "Increasing",
            "Decreasing"});
            this.srxNucleationsAdditionsComboBox.Location = new System.Drawing.Point(123, 84);
            this.srxNucleationsAdditionsComboBox.Name = "srxNucleationsAdditionsComboBox";
            this.srxNucleationsAdditionsComboBox.Size = new System.Drawing.Size(121, 21);
            this.srxNucleationsAdditionsComboBox.TabIndex = 7;
            this.srxNucleationsAdditionsComboBox.SelectedIndexChanged += new System.EventHandler(this.srxNucleationsAdditionsComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nucleations additions:";
            // 
            // srxEnergyValueNumericUpDown
            // 
            this.srxEnergyValueNumericUpDown.DecimalPlaces = 2;
            this.srxEnergyValueNumericUpDown.Location = new System.Drawing.Point(123, 47);
            this.srxEnergyValueNumericUpDown.Name = "srxEnergyValueNumericUpDown";
            this.srxEnergyValueNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.srxEnergyValueNumericUpDown.TabIndex = 4;
            this.srxEnergyValueNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Energy value:";
            // 
            // srxEnergyDistributionComboBox
            // 
            this.srxEnergyDistributionComboBox.FormattingEnabled = true;
            this.srxEnergyDistributionComboBox.Items.AddRange(new object[] {
            "Homogenous",
            "Heterogenous"});
            this.srxEnergyDistributionComboBox.Location = new System.Drawing.Point(123, 18);
            this.srxEnergyDistributionComboBox.Name = "srxEnergyDistributionComboBox";
            this.srxEnergyDistributionComboBox.Size = new System.Drawing.Size(121, 21);
            this.srxEnergyDistributionComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Energy distribution:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Highlight recrystalized:";
            // 
            // srxHighlightRecrystalizedCheckBox
            // 
            this.srxHighlightRecrystalizedCheckBox.AutoSize = true;
            this.srxHighlightRecrystalizedCheckBox.Location = new System.Drawing.Point(123, 261);
            this.srxHighlightRecrystalizedCheckBox.Name = "srxHighlightRecrystalizedCheckBox";
            this.srxHighlightRecrystalizedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.srxHighlightRecrystalizedCheckBox.TabIndex = 20;
            this.srxHighlightRecrystalizedCheckBox.UseVisualStyleBackColor = true;
            this.srxHighlightRecrystalizedCheckBox.CheckedChanged += new System.EventHandler(this.srxHighlightRecrystalizedCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 559);
            this.Controls.Add(this.srxGroupBox);
            this.Controls.Add(this.dpGroupBox);
            this.Controls.Add(this.mcGroupBox);
            this.Controls.Add(this.caGroupBox);
            this.Controls.Add(this.inclusionsGroupBox);
            this.Controls.Add(this.gridGroupBox);
            this.Controls.Add(this.PB);
            this.Name = "MainForm";
            this.Text = "Multiscale Modelling Project - Mateusz Karkula";
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.gridGroupBox.ResumeLayout(false);
            this.gridGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridZoomNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeightNumericUpDown)).EndInit();
            this.inclusionsGroupBox.ResumeLayout(false);
            this.inclusionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inclusionRadiusNumericUpDown)).EndInit();
            this.caGroupBox.ResumeLayout(false);
            this.caGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caGrainsNumericUpDown)).EndInit();
            this.mcGroupBox.ResumeLayout(false);
            this.mcGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mcStepsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcGrainsNumericUpDown)).EndInit();
            this.dpGroupBox.ResumeLayout(false);
            this.dpGroupBox.PerformLayout();
            this.srxGroupBox.ResumeLayout(false);
            this.srxGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srxAddTimesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxStepsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxAddEveryStepsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxNucleationsDiffNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxNucleationsAtStartNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxEnergyValueNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.GroupBox gridGroupBox;
        private System.Windows.Forms.Label gridWidthLabel;
        private System.Windows.Forms.NumericUpDown gridWidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown gridHeightNumericUpDown;
        private System.Windows.Forms.Label gridHeightLabel;
        private System.Windows.Forms.Label gridZoomLabel;
        private System.Windows.Forms.NumericUpDown gridZoomNumericUpDown;
        private System.Windows.Forms.Label gridPeriodicLabel;
        private System.Windows.Forms.CheckBox gridPeriodicCheckBox;
        private System.Windows.Forms.GroupBox inclusionsGroupBox;
        private System.Windows.Forms.Button inclusionCircleButton;
        private System.Windows.Forms.Button inclusionSquareButton;
        private System.Windows.Forms.NumericUpDown inclusionRadiusNumericUpDown;
        private System.Windows.Forms.Label inclusionRadiusLabel;
        private System.Windows.Forms.GroupBox caGroupBox;
        private System.Windows.Forms.Button caAddRandomGrainsButton;
        private System.Windows.Forms.NumericUpDown caGrainsNumericUpDown;
        private System.Windows.Forms.Label caGrainsLabel;
        private System.Windows.Forms.Button caSimulateButton;
        private System.Windows.Forms.ComboBox caNeighborhoodComboBox;
        private System.Windows.Forms.Label caNeighborhoodLabel;
        private System.Windows.Forms.GroupBox mcGroupBox;
        private System.Windows.Forms.ComboBox mcNeighborhoodComboBox;
        private System.Windows.Forms.Label mcNeighborhoodLabel;
        private System.Windows.Forms.Button mcSimulateButton;
        private System.Windows.Forms.Button mcInitRandomGrainsButton;
        private System.Windows.Forms.NumericUpDown mcGrainsNumericUpDown;
        private System.Windows.Forms.Label mcGrainsLabel;
        private System.Windows.Forms.NumericUpDown mcStepsNumericUpDown;
        private System.Windows.Forms.Label mcStepsLabel;
        private System.Windows.Forms.GroupBox dpGroupBox;
        private System.Windows.Forms.Button dpSelectButton;
        private System.Windows.Forms.CheckBox dpChangeIdCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox srxGroupBox;
        private System.Windows.Forms.ComboBox srxEnergyDistributionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox srxNucleationsAdditionsComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown srxEnergyValueNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown srxStepsNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown srxAddEveryStepsNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown srxNucleationsDiffNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown srxNucleationsAtStartNumericUpDown;
        private System.Windows.Forms.Button srxSimulateButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown srxAddTimesNumericUpDown;
        private System.Windows.Forms.CheckBox srxHighlightRecrystalizedCheckBox;
        private System.Windows.Forms.Label label10;
    }
}

