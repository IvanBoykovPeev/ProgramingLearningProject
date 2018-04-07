using System;

namespace _05CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            string printHealth = new string('|', currentHealth);
            string printEnergy = new string('|', currentEnergy);
            string printMaxHealth = new string('.', maximumHealth - currentHealth);
            string printMaxEnergy = new string('.', maximumEnergy - currentEnergy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{printHealth}{printMaxHealth}|");            
            Console.WriteLine($"Energy: |{printEnergy}{printMaxEnergy}|");
        }
    }
}
