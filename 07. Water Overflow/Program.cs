using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CapacityOfTheTank = 255;

            int timesToPour = int.Parse(Console.ReadLine());

            double totalPouredLiteres = 0;

            for (int i = 0; i < timesToPour; i++)
            {
                double currentPouringLeters = double.Parse(Console.ReadLine());
                if (currentPouringLeters + totalPouredLiteres > CapacityOfTheTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                totalPouredLiteres += currentPouringLeters;
            }
            Console.WriteLine(totalPouredLiteres);
        }
    }
}
