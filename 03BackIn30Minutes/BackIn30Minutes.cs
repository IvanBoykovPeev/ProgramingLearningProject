using System;

namespace _03BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;

            if (minutes > 59)
            {
                hours++;
                if (hours > 23)
                {
                    hours = 0;
                    minutes -= 60;
                }
                else
                {
                    minutes -= 60;
                }
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
