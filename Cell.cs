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

        public Cell() : this(0)
        {
            ;
        }

        public Cell(int id)
        {
            this.ID = id;
        }
    }
}
