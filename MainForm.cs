using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace grain_growth
{
    public partial class MainForm : Form
    {
        private Grid grid;
        private GrainGrowthAlgorithm gga;
        private MonteCarloAlgorithm mca;
        private Pen[] pens;
        

        public MainForm()
        {
            InitializeComponent();

            this.grid = new Grid(100, 100, true);

            this.mca = new MonteCarloAlgorithm {Grid = this.grid};
            this.mca.Init(10);

            //this.gga = new GrainGrowthAlgorithm(100, 100, true);
            
            //this.gga.AddSquareInclusion(10,10,10);
            //this.gga.AddCircleInclusion(80, 80, 10);

            //this.gga.AddRandomGrains(5);



            this.pens = new Pen[13];
            this.pens[1] = Pens.Black;
            this.pens[2] = Pens.BlueViolet;
            this.pens[3] = Pens.CornflowerBlue;
            this.pens[4] = Pens.DarkOliveGreen;
            this.pens[5] = Pens.Goldenrod;
            this.pens[6] = Pens.Lavender;
            this.pens[7] = Pens.LightGreen;
            this.pens[8] = Pens.DimGray;
            this.pens[9] = Pens.LightSeaGreen;
            this.pens[10] = Pens.MediumOrchid;
            this.pens[11] = Pens.SaddleBrown;
            this.pens[12] = Pens.Yellow;


        }

        private void PB_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            for (int i = 0; i < 100; ++i)
            {
                for (int j = 0; j < 100; ++j)
                {
                    Cell c = this.grid.GetCell(j, i);

                    if (c.ID != 0)
                    {
                        e.Graphics.DrawRectangle(this.pens[c.ID], j, i, 1, 1);
                    }
                }
            }
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
            for (int i = 0; i < 1000; ++i)
            {
                this.mca.Step();
                this.PB.Refresh();
            }
        }
    }
}
