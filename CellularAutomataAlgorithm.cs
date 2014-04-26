﻿using System;
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
            // 0 is null, 1 is inclusion
            int id = 2;

            for (int i = 0; i < number; ++i)
            {
                Cell c;

                // Look for empty cell
                do
                {
                    c = this.grid.GetCell(this.random.Next(this.Width), this.random.Next(this.Height));
                } while (c.ID != 0);

                c.ID = id++;
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

            counter.AddCells(this.grid.MoorNeighborhoodOfCurrentCell);

            return counter.MostCommonID;
        }
    }
}