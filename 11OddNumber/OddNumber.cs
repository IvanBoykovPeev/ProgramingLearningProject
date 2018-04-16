using System;

namespace _11OddNumber
{
    class OddNumber
    {
        static void Main()
        {
            int inputNumber = 0;
            inputNumber = int.Parse(Console.ReadLine());

            while (inputNumber % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                inputNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(inputNumber)}");
        }
    }
}
