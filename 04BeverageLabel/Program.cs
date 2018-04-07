using System;

namespace _04BeverageLabel
{
    class BeverageLabel
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = int.Parse(Console.ReadLine());
            double energy = int.Parse(Console.ReadLine());
            double sugar = int.Parse(Console.ReadLine());

            double energyPerVolume = (energy * volume) / 100;
            double sugarPerVolume = (sugar * volume) / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyPerVolume}kcal, {sugarPerVolume}g sugars");
        }
    }
}
