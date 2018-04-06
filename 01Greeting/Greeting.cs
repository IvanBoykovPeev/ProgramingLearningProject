using System;

namespace _01Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
