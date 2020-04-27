using System;

namespace TheIrritatingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCasesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCasesCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number / 2} {number / 2}");
                }
                else
                {
                    Console.WriteLine($"{number / 2} {number / 2 + 1}");
                }
            }
        }
    }
}
