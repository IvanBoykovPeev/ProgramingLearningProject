using System;

namespace _03MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            decimal miles = decimal.Parse(Console.ReadLine());
            decimal kilometers = miles * 1.60934m;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
