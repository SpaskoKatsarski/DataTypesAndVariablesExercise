using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "Spasko";
            //Console.WriteLine(name[^1]);

            //int a = 1;
            //Console.WriteLine(5 + a++);
            //Console.WriteLine(5 + ++a);


            int n = int.Parse(Console.ReadLine());

            for (int first = 0; first < n; first++)
            {
                for (int second = 0; second < n; second++)
                {
                    for (int third = 0; third < n; third++)
                    {
                        char firstChar = (char)('a' + first);
                        char secondChar = (char)('a' + second);
                        char thirdChar = (char)('a' + third);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
