using System;

namespace _06TheatrePromotions
{
    class TheatrePromotions
    {
        static void Main()
        {
            string typeOfDay = Console.ReadLine();
            int ageOfPerson = int.Parse(Console.ReadLine());
            int ticketPrice = 0;
            if (typeOfDay == "Weekday")
            {
                if ((ageOfPerson >= 0 && ageOfPerson <= 18)
                    || (ageOfPerson > 64 && ageOfPerson <= 122))
                {
                    ticketPrice = 12;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else if (ageOfPerson > 18 && ageOfPerson <= 64)
                {
                    ticketPrice = 18;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            if (typeOfDay == "Holiday")
            {
                if (ageOfPerson >= 0 && ageOfPerson <= 18)
                {
                    ticketPrice = 5;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else if (ageOfPerson > 18 && ageOfPerson <= 64)
                {
                    ticketPrice = 12;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else if(ageOfPerson > 64 && ageOfPerson <= 122)
                {
                    ticketPrice = 10;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            if (typeOfDay == "Weekend")
            {
                if ((ageOfPerson >= 0 && ageOfPerson <= 18)
                    || (ageOfPerson > 64 && ageOfPerson <= 122))
                {
                    ticketPrice = 15;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else if (ageOfPerson > 18 && ageOfPerson <= 64)
                {
                    ticketPrice = 20;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }            
        }
    }
}
