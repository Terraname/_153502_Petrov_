using System;

namespace _153502_Petrov
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter 1st number ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter 2nd number ");
            b = Convert.ToInt16(Console.ReadLine());
            c = a / b;
            Console.WriteLine($"The quotient is {c}");
        }
    }
}
