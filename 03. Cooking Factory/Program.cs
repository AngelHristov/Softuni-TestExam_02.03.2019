using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Cooking_Factory
{
    class Program
    {
        static void Main()
        {
            List<int> bestBach = new List<int>();
            int bestQuality = int.MinValue;
            double bestAverage = double.MinValue;
            int bestLenght = -1;

            string command = "";
            while ((command = Console.ReadLine()) != "Bake It!")
            {
                List<int> currentBach = command.Split('#').Select(int.Parse).ToList();
                int quality = 0;                
                int lenght = currentBach.Count;
                for (int i = 0; i < currentBach.Count; i++)
                {
                    quality += currentBach[i];
                }
                double average = Math.Abs(quality / currentBach.Count);
                if (quality > bestQuality)
                {
                    bestBach = command.Split('#').Select(int.Parse).ToList();
                    bestQuality = quality;
                    bestAverage = average;
                    bestLenght = lenght;
                }
                else if (quality == bestQuality)
                {
                    if (average > bestAverage)
                    {
                        bestBach = command.Split('#').Select(int.Parse).ToList();
                        bestQuality = quality;
                        bestAverage = average;
                        bestLenght = lenght;
                    }
                    else if (average == bestAverage)
                    {
                        if (lenght < bestLenght)
                        {
                            bestBach = command.Split('#').Select(int.Parse).ToList();
                            bestQuality = quality;
                            bestAverage = average;
                            bestLenght = lenght;
                        }
                    }
                }
            }
            Console.WriteLine($"Best Batch quality: {bestQuality}");
            Console.WriteLine(string.Join(" ", bestBach));
        }
    }
}
