// See https://aka.ms/new-console-template for more information
using ConsoleApp7_1;
Console.WriteLine("Hello, World!");
Matrix m1 = new Matrix(1, 0, 0, 1);
Matrix m2 = (Matrix)5;
Matrix m3 = new Matrix(1, 2, 3, 4);
Matrix m4 = m2 * m3;
Console.Write(m4[0, 0]); Console.Write(" "); Console.WriteLine(m4[0, 1]);
Console.Write(m4[1, 0]); Console.Write(" "); Console.WriteLine(m4[1, 1]);
Matrix m5 = m1 - (Matrix)1;
Matrix m6 = (Matrix)((int)m1 - 1);
Console.Write("m5 =");
Console.Write(m5.toString());
Console.Write("and m6 =");
Console.Write(m6.toString());
if (m5 == m6)
{ Console.WriteLine("are equal"); }
else
{ Console.WriteLine("are not equal"); }
Console.Write("m5 =");
Console.Write(m5.toString());
if(m5)
{
    Console.WriteLine("is true");
}
else
{
    Console.WriteLine("is false");
}
m2++;
Console.Write("m2++");
Console.Write(m2.toString());
Console.Write("m2 + m3 = ");
Console.Write((m2 + m3).toString());
Console.Write("m2 / 2 = ");
m2 = m2 / 2;
Console.Write(m2.toString());
