using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace grain_growth
{
    public partial class MainForm : Form
    {
        #region Properties
        private int GridWidth
        {
            get { return (int)this.gridWidthNumericUpDown.Value; }
        }

        private int GridHeight
        {
            get { return (int)this.gridHeightNumericUpDown.Value; }
        }

        private bool GridPeriodic
        {
            get { return this.gridPeriodicCheckBox.Checked; }
        }

        private int GridZoom
        {
            get { return (int)this.gridZoomNumericUpDown.Value; }
        }

        private int InclusionRadius
        {
            get { return (int)this.inclusionRadiusNumericUpDown.Value; }
        }

        private int CAGrians
        {
            get { return (int)this.caGrainsNumericUpDown.Value; }
        }

        private int MCGrians
        {
            get { return (int)this.mcGrainsNumericUpDown.Value; }
        }

        private int MCSteps
        {
            get { return (int)this.mcStepsNumericUpDown.Value; }
        }

        private bool DPChangeId
        {
            get { return this.dpChangeIdCheckBox.Checked; }
        }
        #endregion Properties

        private Grid grid;
        private CellularAutomataAlgorithm ca;
        private MonteCarloAlgorithm mc;
        private SRXAlgorithm srx;
        private List<Brush> brushes;

        // Store all UI stateButtons 
        
        private Dictionary<Button, StateButtonEvents> stateButtons;
        private Button activeStateButton = null;
        
        public MainForm()
        {
            this.ca = new CellularAutomataAlgorithm();
            this.mc = new MonteCarloAlgorithm();
            this.srx = new SRXAlgorithm();

            InitializeComponent();
            this.SetupUI();
            this.SetupBrushes();
            this.SetupGrid();
            this.SetupStateButtons();

            //this.grid = new Grid(100, 100, false);

            //this.mc = new MonteCarloAlgorithm {Grid = this.grid};
            //this.mc.AddSquareInclusion(10, 10, 10);
            //this.mc.AddCircleInclusion(80, 80, 10);
            //this.mc.Init(5);

            //this.ca = new CellularAutomataAlgorithm { Grid = this.grid };           
            ////this.ca.AddSquareInclusion(10,10,10);
            ////this.ca.AddCircleInclusion(80, 80, 10);
            //this.ca.AddRandomGrains(5);
        }

        private void SetupUI()
        {
            this.caNeighborhoodComboBox.SelectedIndex = 0;
            this.mcNeighborhoodComboBox.SelectedIndex = 0;
        }


        private void girdProperties_Changed(object sender, EventArgs e)
        {
            this.SetupGrid();
            this.SetupPB();
        }

        private void gridZoomNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.SetupPB();
        }

        private void SetupGrid()
        {
            this.grid = new Grid(this.GridWidth, this.GridHeight, this.GridPeriodic);
            this.ca.Grid = this.grid;
            this.mc.Grid = this.grid;
            this.srx.Grid = this.grid;
            this.SetupPB();
        }

        private void SetupPB()
        {
            this.PB.Width = this.GridWidth * this.GridZoom;
            this.PB.Height = this.GridHeight * this.GridZoom;

            this.PB.Refresh();
        }

        /// <summary>
        /// Get all defaults brushes using reflection
        /// and save it to this.brushes
        /// </summary>
        private void SetupBrushes()
        {
            this.brushes = new List<Brush>();
            
            this.brushes.Add(Brushes.Black);

            // Black is for inclusion
            // Random order because similars colors are next to each other

            // this
            this.brushes.AddRange(typeof (Brushes).GetProperties().Where(p => p.Name != "Black").Select(p => p.GetValue(null, null) as Brush).OrderBy(p => RandomHelper.Next())); 
            // do the sam as
            //foreach (PropertyInfo pf in typeof (Brushes).GetProperties().Where(p => p.Name != "Black"))
            //{
            //    this.brushes.Add(pf.GetValue(null, null) as Brush);
            //}

            this.brushes.Insert(0, Brushes.Black);
        }

        private void SetupStateButtons()
        {
            this.stateButtons = new Dictionary<Button, StateButtonEvents>();

            this.stateButtons.Add(this.inclusionCircleButton, new StateButtonEvents{ PBClick = AddCircleInclusion });
            this.stateButtons.Add(this.inclusionSquareButton, new StateButtonEvents { PBClick = AddSquareInclusion });
            this.stateButtons.Add(this.dpSelectButton, new StateButtonEvents { PBClick = SelectGrain, On = SelectGrain_Start, Off = SelectGrain_End });
        }

        private void PB_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            for (int y = 0; y < this.grid.Height; ++y)
            {
                for (int x = 0; x < this.grid.Width; ++x)
                {
                    Cell c = this.grid.GetCell(x, y);

                    if (c.ID != 0)
                    {
                        e.Graphics.FillRectangle(this.brushes[c.ID], x * this.GridZoom, y * this.GridZoom, this.GridZoom, this.GridZoom);                        
                    }
                }
            }
        }

        #region PB click logic
        private void PB_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            int x = me.X / this.GridZoom;
            int y = me.Y / this.GridZoom;

            // Call logic for specific state button
            if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].PBClick != null)
            {
                this.stateButtons[this.activeStateButton].PBClick(x, y);
                this.PB.Refresh();
            }
        }

        private void stateButton_Click(object sender, EventArgs e)
        {
            foreach (Button btn in this.stateButtons.Keys)
            {
                btn.BackColor = SystemColors.Control;
                btn.ForeColor = SystemColors.ControlText;
            }
            
            Button clickedButton = sender as Button;

            // Off logic for prevoius button 
            if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].Off != null)
            {
                this.stateButtons[this.activeStateButton].Off();
            }

            // Click in different button
            if (this.activeStateButton != clickedButton)
            {
                this.activeStateButton = clickedButton;
                clickedButton.BackColor = SystemColors.Highlight;
                clickedButton.ForeColor = SystemColors.HighlightText;

                // On logic
                if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].On != null)
                {
                    this.stateButtons[this.activeStateButton].On();
                }
            }

            // Unclick active button
            else
            {
                this.activeStateButton = null;
            }
        }

        private void AddCircleInclusion(int x, int y)
        {
            // Method from AlgorithmBase
            this.ca.AddCircleInclusion(x, y, this.InclusionRadius);
        }

        private void AddSquareInclusion(int x, int y)
        {
            // Method from AlgorithmBase
            this.ca.AddSquareInclusion(x, y, this.InclusionRadius); ;
        }

        private void SelectGrain_Start()
        {
            this.ca.StartSelectGrains(this.DPChangeId);
        }

        private void SelectGrain(int x, int y)
        {
            this.ca.SelectGrain(x, y);
            this.PB.Refresh();
        }

        private void SelectGrain_End()
        {
            this.ca.EndSelectGrains();
            this.PB.Refresh();
        }

        #endregion PB click logic

        private void caAddRandomGrainsButton_Click(object sender, EventArgs e)
        {
            this.ca.AddRandomGrains(this.CAGrians);
            this.PB.Refresh();
        }

        private void caSimulateButton_Click(object sender, EventArgs e)
        {
            while (this.ca.Step())
            {
                this.PB.Refresh();
            }
        }

        private void mcInitRandomGrainsButton_Click(object sender, EventArgs e)
        {
            this.mc.Init(this.MCGrians);
            this.PB.Refresh();
        }

        private void mcSimulateButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MCSteps; ++i)
            {
                this.mc.Step();
                this.PB.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.srx.AddNucleations(10);
            this.PB.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.srx.Step();
            this.PB.Refresh();
        }
    }
}
