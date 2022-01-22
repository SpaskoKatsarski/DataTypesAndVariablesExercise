using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            long result = (long)firstNumber + secondNumber;
            result /= thirdNumber;
            result *= fourthNumber;

            Console.WriteLine(result);

            //long firstNum1 = long.Parse(Console.ReadLine());
            //long firstNum2 = long.Parse(Console.ReadLine());

            //int result1 = (int)firstNum1 + (int)firstNum2;

            //Console.WriteLine(result1);
        }
    }
}
