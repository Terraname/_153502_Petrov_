using System;

namespace Petrov_lab2_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Enter x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y");
            y = Convert.ToDouble(Console.ReadLine());
            double dist = x * x + y * y;
            if (dist > 15 * 15 && dist < 25 * 25)
            {
                Console.WriteLine("Да");
            }
            else if (dist == 15 * 15 || dist == 25 * 25)
            {
                Console.WriteLine("На границе");
            }
            else
            {
                Console.WriteLine("Нет");
            }         
        }

        static int check(double x, double y)
        {
            double dist = x * x + y * y;
            if (dist > 15 * 15 && dist < 25 * 25)
            {
                return 1;
            }
            else if (dist == 15 * 15 || dist == 25 * 25)
            {
                return 0;
            }

            return -1;
        }
    }
}
