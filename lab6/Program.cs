// See https://aka.ms/new-console-template for more information
using ConsoleApp6._1;
Console.WriteLine("Hello, World!");
Star Sun = new Star("Sun", 0, 3000, 1e9, 9e7, 0, 0, 1);
Planet Earth = new Planet(true, "Earth", 8000000000, 283, 1, 0, 0, 0);
Sun.AddSatellite(Earth);
MicroPlanet Moon = new MicroPlanet(false, "Moon", 0, 243, 7e-6,-5e4, 0, 0);
Earth.AddSatellite(Moon);
//Sun.Print();
Sun.PrintWithSatellites();
Moon.Print();
/*namespace ConsoleApp6._1
{
    class Program
    {
        Star
    }

}*/

