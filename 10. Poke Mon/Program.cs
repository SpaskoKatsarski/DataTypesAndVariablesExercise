using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int originalValueOfPokePower = pokePower;

            int pokedTargets = 0;

            while (pokePower >= distanceBetweenTargets)
            {
                if (pokePower == originalValueOfPokePower * 0.5m)
                {
                    if (exhaustionFactor == 0)
                    {
                        pokePower -= distanceBetweenTargets;
                    }
                    else
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
                else
                {
                    pokePower -= distanceBetweenTargets;
                    pokedTargets++;
                }
            }

            Console.WriteLine($"{pokePower}\n{pokedTargets}");
        }
    }
}
