using System;
using System.Linq;

namespace SumOfSquares
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
            int sum = 0;

            for (int i = numbers[0]; i <= lastValue; i++)
            {
                sum += i * i;
            }
            Console.WriteLine(sum);
        }
    }
}
