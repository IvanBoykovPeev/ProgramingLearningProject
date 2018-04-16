using System;

namespace _08SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < number * 2; i += 2)
            {
                Console.WriteLine(i);
                sum += i;   
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
