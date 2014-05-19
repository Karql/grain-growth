using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace grain_growth
{
    public class MonteCarloAlgorithm : AlgorithmBase
    {
        public void Init(int randomGrains)
        {
            this.grid.ResetCurrentCellPosition();

            // Iterate cells line by line
            do
            {
                this.grid.CurrentCell.ID = this.random.Next(randomGrains) + 2; // + 2 empty, inclusion 
                //// Grain can grwoth only on empty cell
                //if (this.grid.CurrentCell.ID == 0)
                //{
                //    if (this.Moore())
                //    {
                //        ++changes;
                //    }
                //}
            } while (this.grid.Next());
        }

        public void Step()
        {
            int x;
            int y;

            do
            {
                x = this.random.Next(this.grid.Width);
                y = this.random.Next(this.grid.Height);
            }  while (!this.IsCorrectRandomCell(x, y));

            Stopwatch s = new Stopwatch();

            s.Start();
            Cell[] cells = this.grid.NeighborhoodOfCurrentCell;
            s.Stop();

            int[] neighborsId = cells.Where(i => i.ID > 1).Select(i => i.ID).ToArray();
            
            int e1 = neighborsId.Where(i => i != this.grid.CurrentCell.ID).Count();
            int newId = neighborsId[this.random.Next(neighborsId.Length)];
            int e2 = neighborsId.Where(i => i != newId).Count();

            if (e2 - e1 <= 0)
            {
                this.grid.CurrentCell.ID = newId;
            }
        }



        private bool IsCorrectRandomCell(int x, int y)
        {
            this.grid.SetCurrentCellPosition(x, y);

            // TODO: expand condition
            return this.grid.CurrentCell.ID > 1;
        }
    }
}
