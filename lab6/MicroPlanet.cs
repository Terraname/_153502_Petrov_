using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._1
{
    sealed public class MicroPlanet: Planet
    {

        public MicroPlanet(bool HasWater, string name, UInt64 population, Double SurfaceTEmperature, Double mass, Double x, Double y, Double z) :
            base(HasWater, name, population, SurfaceTEmperature, mass, x, y, z)
        { }

        public new void Print()
        {
            //Console.WriteLine($"type: {this.GetType}");
            Console.WriteLine($"type: MicroPlanet");
            Console.WriteLine($"has water: {this.HasWater}");
            base.Print();
        }
    }
}
