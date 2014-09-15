using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace grain_growth
{
    public class CellularAutomataAlgorithm : AlgorithmBase
    {
        /// <summary>
        /// Add grains in random positions
        /// </summary>
        public void AddRandomGrains(int number)
        {
            int[] notUsedIds = this.GetNotUsedIds();

            for (int i = 0; i < number; ++i)
            {
                if (i < notUsedIds.Length)
                {
                    Cell c;

                    // Look for empty cell
                    do
                    {
                        c = this.grid.GetCell(RandomHelper.Next(this.Width), RandomHelper.Next(this.Height));
                    } while (c.ID != 0 || c.Selected);

                    c.ID = notUsedIds[i];
                }

                else
                {
                    // No more id
                    break;
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
                    if (this.Moore(this.grid.CurrentCell))
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
        protected bool Moore(Cell c)
        {
            CounterReturn cr = this.MooreMostCommonCell(c);
            
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
        protected CounterReturn MooreMostCommonCell(Cell c)
        {
            Counter counter = new Counter();

            counter.AddCells(c.MoorNeighborhood);

            return counter.MostCommonID;
        }
    }
}
