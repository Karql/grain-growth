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
    }
}
