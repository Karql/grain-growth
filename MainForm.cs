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
        GrainGrowthAlgorithm gga;
        Pen[] pens;
        

        public MainForm()
        {
            InitializeComponent();

            this.gga = new GrainGrowthAlgorithm(100, 100, false);
            this.gga.AddRandomGrains(5);

            this.pens = new Pen[8];
            this.pens[2] = Pens.AliceBlue;
            this.pens[3] = Pens.CornflowerBlue;
            this.pens[4] = Pens.DarkOliveGreen;
            this.pens[5] = Pens.Goldenrod;
            this.pens[6] = Pens.Lavender;
            this.pens[7] = Pens.LightGreen;


        }

        private void PB_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            for (int i = 0; i < 100; ++i)
            {
                for (int j = 0; j < 100; ++j)
                {
                    Cell c = this.gga.Grid.GetCell(j, i);

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
    }
}
