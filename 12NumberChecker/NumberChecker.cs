using System;

namespace _12NumberChecker
{
    class NumberChecker
    {
        static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
