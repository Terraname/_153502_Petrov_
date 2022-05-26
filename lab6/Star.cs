using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using SpaceObject;

namespace ConsoleApp6._1
{
    public class Star: SpaceObject
    {
        Double brightness = 1;
        override public void AddSatellite() { Array.Resize(ref Satellites, Satellites.Length + 1); }
        public void AddSatellite(SpaceObject satel, int pos) { if(pos >= 0 && pos < Satellites.Length)Satellites.SetValue(satel, pos); }

        public void AddSatellite(SpaceObject satel) { this.AddSatellite(); Satellites.SetValue(satel, Satellites.Length-1); }
        public override void Print()
        {
            //Console.WriteLine($"type: {this.type}");
            Console.WriteLine($"type: Star");
            Console.WriteLine($"brightness: {brightness}");
            base.Print();
        }

        public void PrintWithSatellites()
        {
            Console.WriteLine($"type: Star");
            Console.WriteLine($"brightness: {brightness}");
            base.Print();
            foreach(SpaceObject s in Satellites)
            {
                s.Print();
            }
        }
        public Star(string name, UInt64 population, Double SurfaceTEmperature, Double mass, Double x, Double y, Double z, Double brightness):
            base(name, population, SurfaceTEmperature, mass, x, y, z) { this.brightness = brightness;}
    }
}
