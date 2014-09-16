using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;

namespace grain_growth
{
    public class MonteCarloAlgorithm : AlgorithmBase
    {
        public void Init(int randomGrains)
        {
            int[] notUsedIds = this.GetNotUsedIds().Take(randomGrains).ToArray();

            this.grid.ResetCurrentCellPosition();

            // Iterate cells line by line
            do
            {                
                // Nucleon can only be put on empty cell
                if (this.grid.CurrentCell.ID == 0)
                {
                    this.grid.CurrentCell.ID = notUsedIds[RandomHelper.Next(randomGrains)];
                }
            } while (this.grid.Next());
        }

        public void Step()
        {            
            foreach (Cell c in this.GetCellsToProcess())
            {
                int[] neighborsId = c.MoorNeighborhood.Where(i => i.ID > 1 && !i.Selected).Select(i => i.ID).ToArray();

                int e1 = neighborsId.Where(i => i != c.ID).Count();
                int newId = neighborsId[RandomHelper.Next(neighborsId.Length)];
                int e2 = neighborsId.Where(i => i != newId).Count();

                if (e2 - e1 <= 0)
                {
                    c.ID = newId;
                }
            }
        }

        private IEnumerable<Cell> GetCellsToProcess()
        {
            List<Cell> cells = new List<Cell>();

            this.grid.ResetCurrentCellPosition();

            do
            {
                if (this.IsCorrectRandomCell(this.grid.CurrentCell))
                {
                    cells.Add(this.grid.CurrentCell);
                }
            } while (this.grid.Next());

            // Random order
            return cells.OrderBy(i => RandomHelper.Next());            
        }
        
        private bool IsCorrectRandomCell(Cell cell)
        {
            return cell.ID > 1 && !cell.Selected && cell.MoorNeighborhood.Where(i => i.ID != cell.ID && !i.Selected).Count() > 0;
        }
    }
}
