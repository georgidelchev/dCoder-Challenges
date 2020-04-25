using System;
using System.Linq;

namespace LearningSortingNumbers
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

            int[] sortedNumbers = numbers.OrderBy(i => i).ToArray();
            foreach (var item in sortedNumbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
