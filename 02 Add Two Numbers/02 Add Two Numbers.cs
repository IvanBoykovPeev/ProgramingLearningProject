using System;

namespace _02_Add_Two_Numbers
{
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var sum = firstNumber + secondNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
        }
    }
}
