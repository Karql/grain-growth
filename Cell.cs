using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{
    public class Cell
    {
        /// <summary>
        /// Id of grain
        /// 0  - null
        /// 1  - inclusion
        /// >1 - grain
        /// </summary>
        public int ID { set; get; }
        /// <summary>
        /// For store new id
        /// </summary>
        public int NewID { set; get; }
        /// <summary>
        /// Select for dual phase (do not change more)
        /// </summary>
        public bool Selected { set; get; }

        public bool Recrystalized { set; get; }

        public double Energy { set; get; }
        /// <summary>
        /// Neighbors of cell clockwise starts from 12 o'clock
        /// </summary>
        public Cell[] Neighbors { set; get; }

        public Cell() : this(0)
        {
            ;
        }

        public Cell(int id)
        {
            this.ID = id;
        }

        #region Neighbors
        // Neighbors of current cell by directions of the world
        public Cell NeighborN
        {
            get { return this.Neighbors[0]; }
        }

        public Cell NeighborNW
        {
            get { return this.Neighbors[1]; }
        }

        public Cell NeighborW
        {
            get { return this.Neighbors[2]; }
        }

        public Cell NeighborSW
        {
            get { return this.Neighbors[3]; }
        }

        public Cell NeighborS
        {
            get { return this.Neighbors[4]; }
        }

        public Cell NeighborSE
        {
            get { return this.Neighbors[5]; }
        }

        public Cell NeighborE
        {
            get { return this.Neighbors[6]; }
        }

        public Cell NeighborNE
        {
            get { return this.Neighbors[7]; }
        }

        public IEnumerable<Cell> MoorNeighborhood
        {
            get { return this.Neighbors; }
        }

        public IEnumerable<Cell> VonNeumannNeighborhood
        {
            get { return new Cell[] {this.NeighborN, this.NeighborE, this.NeighborS, this.NeighborW}; }
        }
        #endregion
    }
}
