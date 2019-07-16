using System;

namespace _02._Bread_Factory
{
    class Program
    {
        static void Main()
        {
            int energy = 100;
            int coins = 100;
            string[] dayEvents = Console.ReadLine().Split('|');

            for (int i = 0; i < dayEvents.Length; i++)
            {
                string[] day = dayEvents[i].Split("-");
                int value = int.Parse(day[1]);
                if (day[0] == "rest")
                {                   
                    if (energy + value <= 100)
                    {
                        energy += value;
                    }
                    else
                    {
                        int energyLeft = energy + value - 100;
                        value -= energyLeft;
                        energy += value;
                    }
                    Console.WriteLine($"You gained {value} energy.");
                    Console.WriteLine($"Current energy: {energy}.");
                }
                else if (day[0] == "order")
                {
                    energy -= 30;
                    if (energy >= 0)
                    {
                        coins += value;
                        Console.WriteLine($"You earned {value} coins.");
                    }
                    else
                    {
                        energy += 80;
                        Console.WriteLine("You had to rest!");
                    }
                }
                else
                {
                    coins -= value;
                    if (coins > 0)
                    {
                        Console.WriteLine($"You bought {day[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {day[0]}.");
                        break;
                    }
                }
            }
            if (coins > 0)
            {
                Console.WriteLine("Day completed!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Energy: {energy}");
            }
        }
    }
}
