using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{
    public static class RandomHelper
    {
        private static Random random = new Random();

        public static int Next()
        {
            return RandomHelper.random.Next();
        }

        public static int Next(int maxValue)
        {
            return RandomHelper.random.Next(maxValue);
        }
    }
}
