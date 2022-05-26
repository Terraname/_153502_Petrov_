using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._1
{
    public class Planet: SpaceObject
    {
        public bool HasWater = false;
        override public bool Habitable() { if (this.HasWater && this.SurfaceTemperature >= 210 && this.SurfaceTemperature <= 370) return true; return false; }

        public Planet(bool HasWater, string name, UInt64 population, Double SurfaceTEmperature, Double mass, Double x, Double y, Double z) :
            base(name, population, SurfaceTEmperature, mass, x, y, z)
        { this.HasWater = HasWater; }

        override public void AddSatellite() { Array.Resize(ref Satellites, Satellites.Length + 1); }
        public void AddSatellite(SpaceObject satel, int pos) { if (pos >= 0 && pos < Satellites.Length) Satellites.SetValue(satel, pos); }
        public void AddSatellite(SpaceObject satel) { this.AddSatellite(); Satellites.SetValue(satel, Satellites.Length-1); }
        public override void Print()
        {
            //Console.WriteLine($"type: {this.GetType}");
            Console.WriteLine($"type: Planet");
            Console.WriteLine($"has water: {this.HasWater}");
            base.Print();
        }
    }
}
