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
        #endregion Properties

        private Grid grid;
        private CellularAutomataAlgorithm gga;
        private MonteCarloAlgorithm mca;
        private List<Brush> brushes;

        // Store all UI stateButtons 
        private delegate void PBClickLogic(int x, int y);
        private Dictionary<Button, PBClickLogic> stateButtons;
        private Button activeStateButton = null;
        
        public MainForm()
        {
            InitializeComponent();
            this.SetupBrushes();
            this.SetupGrid();
            this.SetupStateButtons();

            //this.grid = new Grid(100, 100, false);

            this.mca = new MonteCarloAlgorithm {Grid = this.grid};
            this.mca.AddSquareInclusion(10, 10, 10);
            this.mca.AddCircleInclusion(80, 80, 10);
            this.mca.Init(5);

            this.gga = new CellularAutomataAlgorithm { Grid = this.grid };           
            ////this.gga.AddSquareInclusion(10,10,10);
            ////this.gga.AddCircleInclusion(80, 80, 10);
            //this.gga.AddRandomGrains(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (this.gga.Step())
            {
                this.PB.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; ++i)
            {
                this.mca.Step();
                this.PB.Refresh();
            }

            this.mca.AddSquareInclusion(30, 30, 10);
            this.PB.Refresh();
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
            this.stateButtons = new Dictionary<Button, PBClickLogic>();

            this.stateButtons.Add(this.inclusionCircleButton, AddCircleInclusion);
            this.stateButtons.Add(this.inclusionSquareButton, AddSquareInclusion);
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
            if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton))
            {
                this.stateButtons[this.activeStateButton](x, y);
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

            // Click in different button
            if (this.activeStateButton != clickedButton)
            {
                this.activeStateButton = clickedButton;
                clickedButton.BackColor = SystemColors.Highlight;
                clickedButton.ForeColor = SystemColors.HighlightText;
            }

            // Unclick active button
            else
            {
                this.activeStateButton = null;
            }
        }

        private void AddCircleInclusion(int x, int y)
        {
            AlgorithmBase ab = new AlgorithmBase {Grid = this.grid};
            ab.AddCircleInclusion(x, y, this.InclusionRadius);
        }

        private void AddSquareInclusion(int x, int y)
        {
            AlgorithmBase ab = new AlgorithmBase { Grid = this.grid };
            ab.AddSquareInclusion(x, y, this.InclusionRadius); ;
        }
        #endregion PB click logic
    }
}
