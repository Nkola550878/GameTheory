using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTheory
{
    internal class Tools
    {
        public static Random r = new Random();
        public static double Random(double min, double max)
        {
            return r.NextDouble() * (max - min) + min;
        }

        public static int Random(int min, int max)
        {
            return r.Next(min, max);
        }
    }
}
