using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareVal
{
    public class Compare
    {   
        public static Int64 minv(Int64 a, Int64 b)
        {
            if(a > b)
            {
                return b;
            }

            return a;
        }

        public static double minv(double a, double b)
        {
            if(a > b)
            {
                return b;
            }
            return a;
        }
    }
}
