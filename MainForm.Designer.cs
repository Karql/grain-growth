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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.gridGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridZoomNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeightNumericUpDown)).BeginInit();
            this.inclusionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inclusionRadiusNumericUpDown)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(580, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
            this.inclusionCircleButton.Location = new System.Drawing.Point(9, 76);
            this.inclusionCircleButton.Name = "inclusionCircleButton";
            this.inclusionCircleButton.Size = new System.Drawing.Size(106, 23);
            this.inclusionCircleButton.TabIndex = 10;
            this.inclusionCircleButton.Text = "Circle";
            this.inclusionCircleButton.UseVisualStyleBackColor = false;
            this.inclusionCircleButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // inclusionSquareButton
            // 
            this.inclusionSquareButton.Location = new System.Drawing.Point(9, 47);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 639);
            this.Controls.Add(this.inclusionsGroupBox);
            this.Controls.Add(this.gridGroupBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PB);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.gridGroupBox.ResumeLayout(false);
            this.gridGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridZoomNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeightNumericUpDown)).EndInit();
            this.inclusionsGroupBox.ResumeLayout(false);
            this.inclusionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inclusionRadiusNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
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
    }
}

