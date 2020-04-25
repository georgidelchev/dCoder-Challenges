using System;
using System.Linq;

namespace TheBlackJackWithConditions
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

            if (numbers[0] == 11)
            {
                numbers[0] = 1;
            }

            if (numbers[1] == 11)
            {
                numbers[1] = 1;
            }

            int sum = 0;
            foreach (var nums in numbers)
            {
                sum += nums;
            }

            if (sum > 20)
            {
                sum = 0;
            }

            Console.WriteLine(sum);
        }
    }
}
