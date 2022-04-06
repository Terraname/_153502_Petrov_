// See https://aka.ms/new-console-template for more information
using CompareVal;

Int64 x, y;
Console.WriteLine("z=min(x,2y+x)-min(7x+2y,y)");
Console.WriteLine("Enter x");
x = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Enter y");
y = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("z = ");
Console.Write(Compare.minv(x, 2*y+x)-Compare.minv(7*x+2*y, y));

