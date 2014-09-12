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

        private Grid grid;
        private CellularAutomataAlgorithm gga;
        private MonteCarloAlgorithm mca;
        private List<Brush> brushes;
        

        public MainForm()
        {
            InitializeComponent();
            this.SetupBrushes();
            this.SetupGrid();

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

        private void PB_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            for (int y = 0; y < this.grid.Height; ++y)
            {
                for (int x = 0; x < 100; ++x)
                {
                    Cell c = this.grid.GetCell(x, y);

                    if (c.ID != 0)
                    {
                        e.Graphics.FillRectangle(this.brushes[c.ID], y * this.GridZoom, x * this.GridZoom, this.GridZoom, this.GridZoom);                        
                    }
                }
            }
        }
    }
}
