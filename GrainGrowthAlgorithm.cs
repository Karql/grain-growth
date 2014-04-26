using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace grain_growth
{
    public class GrainGrowthAlgorithm
    {
        public int Width { set; get; }
        public int Height { set; get; }
        protected Grid grid;

        public Grid Grid
        {
            get
            {
                return this.grid;
            }
        }

        public GrainGrowthAlgorithm(int width, int height, bool periodic)
        {
            this.Width = width;
            this.Height = height;

            this.grid = new Grid(width, height, periodic);
        }

        /// <summary>
        /// Add grains in random positions
        /// </summary>
        public void AddRandomGrains(int number)
        {
            // 0 is null, 1 is inclusion
            int id = 2;

            Random rnd = new Random();

            for (int i = 0; i < number; ++i)
            {
                Cell c;

                // Look for empty cell
                do
                {
                    c = this.grid.GetCell(rnd.Next(this.Width), rnd.Next(this.Height));
                } while (c.ID != 0);

                c.ID = id++;
            }
        }

        public void AddSquareInclusion(int x0, int y0, int size)
        {
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    Cell c = this.grid.GetCell(x0 + i, y0 + j);
                    c.ID = 1;
                    c.NewID = 1;
                }
            }
        }

        /// <summary>
        /// Step of growth
        /// </summary>
        /// <returns>true if any changes made</returns>
        public bool Step()
        {
            int changes = 0;

            this.grid.ResetCurrentCellPosition();

            // Iterate cells line by line
            do
            {
                // Grain can grwoth only on empty cell
                if (this.grid.CurrentCell.ID == 0)
                {
                    if (this.Moore())
                    {
                        ++changes;
                    }
                }
            } while (this.grid.Next());

            if (changes > 0)
            {
                // Copy values  
                this.grid.CopyNewIDtoID();

                return true;
            }

            return false;
        }

        /// <summary>
        /// Change current cell with Moore rules
        /// </summary>
        /// <returns></returns>
        protected bool Moore()
        {
            CounterReturn cr = this.MooreMostCommonCell();
            
            if (cr != null)
            {
                this.grid.CurrentCell.NewID = cr.ID;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Look for most common cell of current cell Moore neighborhood
        /// </summary>
        /// <returns>Most common cell with count or null</returns>
        protected CounterReturn MooreMostCommonCell()
        {
            Counter counter = new Counter();
            counter.AddCell(this.grid.NeighborN);
            counter.AddCell(this.grid.NeighborNE);
            counter.AddCell(this.grid.NeighborE);
            counter.AddCell(this.grid.NeighborSE);
            counter.AddCell(this.grid.NeighborS);
            counter.AddCell(this.grid.NeighborSW);
            counter.AddCell(this.grid.NeighborW);
            counter.AddCell(this.grid.NeighborNW);

            return counter.MostCommonID;
        }
    }
}
