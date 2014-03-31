using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{
    public class MathFunctions
    {
        /// <summary>
        /// Standard modulo operation wroks incorrect
        /// </summary>        
        public static int MathMod(int a, int b)
        {
            return ((a % b) + b) % b;
        }
    }
}
