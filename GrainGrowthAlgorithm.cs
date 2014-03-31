using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{
    public class GrainGrowthAlgorithm
    {
        public int Width { set; get; }
        public int Height { set; get; }
        protected Grid grid;

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
    }
}
