using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadFactory
{
    public class Program
    {
        public static void Main()
        {
            string[] events = Console.ReadLine()
                .Split('|')
                .ToArray();

            int energy = 100;
            int coins = 100;
            for (var i = 0; i < events.Length; i++)
            {
                string[] currentEvent = events[i].Split('-').ToArray();
                string action = currentEvent[0];
                int number = int.Parse(currentEvent[1]);

                if (action == "rest")
                {
                    int currentEnergy = energy;
                    energy += number;
                    if (energy > 100)
                    {
                        Console.WriteLine($"You gained {100 - currentEnergy} energy.");
                        Console.WriteLine("Current energy: 100.");
                        energy = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You gained {number} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                }
                else if (action == "order")
                {
                    energy -= 30;
                    if (energy >= 0)
                    {
                        coins += number;
                        Console.WriteLine($"You earned {number} coins.");
                    }
                    else
                    {
                        energy += 80;
                        Console.WriteLine("You had to rest!");
                    }
                }
                else
                {
                    coins -= number;
                    if (coins > 0)
                    {
                        Console.WriteLine($"You bought {action}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {action}.");
                        return;
                    }
                }
            }
            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}