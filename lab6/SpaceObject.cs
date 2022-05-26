using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//using System.Array;

namespace ConsoleApp6._1
{
    public class SpaceObject
    {
        public string _name = "";
        public UInt64 population = 0;
        public Double SurfaceTemperature;
        public Double mass;
        public Double[] _position = new double[3];
        public SpaceObject[] Satellites = new SpaceObject[0];
        ///Array<SpaceObject> Satellites;
        //SpaceObject Satellites = null;
        //Double starValue
        virtual public void AddSatellite() { }

        virtual public void Print()
        {
            Console.WriteLine($"name: {_name}");
            Console.WriteLine($"mass: {mass}");
            Console.WriteLine($"population: {population}");
            Console.WriteLine($"surface temperature: {SurfaceTemperature}");
            Console.WriteLine($"coordinates: (x = {_position[0]}, y = {_position[1]}, z = {_position[2]})");
            Console.WriteLine($"has {Satellites.Length} satellites:");
            foreach (var s in Satellites) { Console.WriteLine(s._name); }
        }
        public bool IsInhabited()
        {
            if(population == 0)
                return false;
            return true;
        }
        virtual public bool Habitable() { return false; }
        public SpaceObject(string name, UInt64 population, Double SurfaceTEmperature, Double mass, Double x, Double y, Double z) 
        {
            Console.WriteLine("\nConstructing SpaceObject...\n");
            this._name = name;
            this.population = population;
            this.SurfaceTemperature = SurfaceTEmperature;
            this.mass = mass;
            this._position[0] = x;
            this._position[1] = y;
            this._position[2] = z;
        }

    }
}
