// See https://aka.ms/new-console-template for more information
using DataServices;

Console.WriteLine("Enter date");
string date;
date = Console.ReadLine();
switch(DataService.GetDay(date))
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednsday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine(DataService.GetDay(date));
        break;
}
