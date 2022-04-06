using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Myclass
{
    public class Class1
    {
        static public double func(double k, double z)
        {
            if(k<1)
            {
                Console.WriteLine("1st case");
                double x = k * Math.Pow(z, 3);
                Console.WriteLine(Math.Pow(Math.Log(1 + x * x) + Math.Cos(x + 1), Math.Exp(k * x)));
                return (Math.Pow(Math.Log(1 + x * x) + Math.Cos(x + 1), Math.Exp(k * x)));
            }
            else
            {
                Console.WriteLine("2nd case");
                double x = z * (z + 1);
                Console.WriteLine(Math.Pow(Math.Log(1 + x * x) + Math.Cos(x + 1), Math.Exp(k * x)));
                return (Math.Pow(Math.Log(1 + x * x) + Math.Cos(x + 1), Math.Exp(k * x)));
            }

        }
    }
}
