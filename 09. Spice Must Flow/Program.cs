using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            int totalSpices = 0;
            int days = 0;

            while (yield >= 100)
            {
                totalSpices += yield;
                days++;

                if (totalSpices >= 26)
                {
                    totalSpices -= 26;
                }
                yield -= 10;
            }

            if (totalSpices >= 26)
            {
                totalSpices -= 26;
            }
            Console.WriteLine($"{days}\n{totalSpices}");
        }
    }
}
