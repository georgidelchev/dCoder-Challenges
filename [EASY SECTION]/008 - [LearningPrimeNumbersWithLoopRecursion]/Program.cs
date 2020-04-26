using System;
using System.Linq;

namespace LearningPrimeNumbersWithLoopRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int lastValue = numbers[numbers.Length - 1];
            for (int i = numbers[0]; i <= lastValue; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }
                if (counter == 0 && i != 1)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
