using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int totalSum = 0;

            while (number != 0)
            {
                int currentDigit = number % 10;
                totalSum += currentDigit;
                number /= 10;
            }

            Console.WriteLine(totalSum);
        }
    }
}
