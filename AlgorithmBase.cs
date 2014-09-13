using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{
    public class AlgorithmBase
    {
        public int Width { set; get; }
        public int Height { set; get; }
        protected Grid grid;
        //protected Random random = new Random();

        public Grid Grid
        {
            get
            {
                return this.grid;
            }

            set
            {
                this.grid = value;
                this.Width = this.grid.Width;
                this.Height = this.grid.Height;
            }
        }

        /// <summary>
        /// Add square inclusion to structure
        /// </summary>
        /// <param name="x0">left top corner of square</param>
        /// <param name="y0">left top corner of square</param>
        /// <param name="size">size of square</param>
        public void AddSquareInclusion(int x0, int y0, int size)
        {
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    this.AddInclusion(x0 + i, y0 + j);
                }
            }
        }

        /// <summary>
        /// Add circle inclusion to structure
        /// http://stackoverflow.com/questions/1201200/fast-algorithm-for-drawing-filled-circles (@fins answer)
        /// </summary>
        /// <param name="x0">center of circle</param>
        /// <param name="y0">center of circle</param>
        /// <param name="radius">circle radius</param>
        public void AddCircleInclusion(int x0, int y0, int radius)
        {
            int x = radius;
            int y = 0;
            int xChange = 1 - (radius << 1);
            int yChange = 0;
            int radiusError = 0;

            while (x >= y)
            {
                for (int i = x0 - x; i <= x0 + x; i++)
                {
                    this.AddInclusion(i, y0 + y);
                    this.AddInclusion(i, y0 - y);
                }
                for (int i = x0 - y; i <= x0 + y; i++)
                {
                    this.AddInclusion(i, y0 + x);
                    this.AddInclusion(i, y0 - x);
                }

                y++;
                radiusError += yChange;
                yChange += 2;
                if (((radiusError << 1) + xChange) > 0)
                {
                    x--;
                    radiusError += xChange;
                    xChange += 2;
                }
            }
        }

        /// <summary>
        /// Add inclusion to single cell
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        protected void AddInclusion(int x, int y)
        {
            Cell c = this.grid.GetCell(x, y);
            c.ID = 1;
            c.NewID = 1;
        }
    }
}
