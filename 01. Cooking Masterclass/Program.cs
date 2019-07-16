using System;

namespace _01._Cooking_Masterclass
{
    class Program
    {
        static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            int freePackages = students / 5;

            double sum = apronPrice * (students + Math.Ceiling(0.2 * students))
                + eggPrice * 10 * (students) + flourPrice * (students - freePackages);

            if (budget >= sum)
            {
                Console.WriteLine($"Items purchased for {sum:F2}$.");
            }
            else
            {
                Console.WriteLine($"{(sum - budget):F2}$ more needed.");
            }
        }
    }
}
