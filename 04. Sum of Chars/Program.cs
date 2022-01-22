using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());

                sum += currentChar;
            }

            Console.WriteLine($"The sum equals: {sum}");

            //char ch = '3';
            //int number = ch - '0';
            //Console.WriteLine(number); ;

            //char symbol = '\u00B5';

            //char ch = 'Σ';
            //Console.WriteLine(ch);
        }
    }
}
