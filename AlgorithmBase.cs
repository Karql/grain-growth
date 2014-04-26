using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{
    public abstract class AlgorithmBase
    {
        public int Width { set; get; }
        public int Height { set; get; }
        protected Grid grid;
        protected Random random = new Random();

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

        //public AlgorithmBase()
        //{
        //    this.Width = 0;
        //    this.Height = 0;
        //    this.grid = null;
        //}

        //public AlgorithmBase(Grid grid)
        //{
        //    this.grid = grid;
        //    this.Width = this.grid.Width;
        //    this.Height = this.grid.Height;
        //}
    }
}
