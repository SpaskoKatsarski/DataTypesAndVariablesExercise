using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string bestModel = String.Empty;
            double biggestVolume = -1;

            for (int i = 0; i < n; i++)
            {
                string currentModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                // π * r^2 * h.
                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > biggestVolume)
                {
                    bestModel = currentModel;
                    biggestVolume = volume;
                }
            }

            Console.WriteLine(bestModel);
        }
    }
}
