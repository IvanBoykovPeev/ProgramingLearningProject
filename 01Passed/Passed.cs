﻿using System;

namespace _01Passed
{
    class Passed
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
