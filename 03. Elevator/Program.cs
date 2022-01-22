using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int fullCourses = (int)Math.Ceiling((double)people / capacity);
            if (people / capacity != 0)
            {
                fullCourses++;
            }

            if (people <= capacity )
            {
                Console.WriteLine(1);
                return;
            }

            Console.WriteLine(fullCourses - 1);
        }
    }
}
