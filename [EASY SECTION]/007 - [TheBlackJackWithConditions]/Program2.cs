using System;
using System.Linq;

namespace TheBlackJackWithConditionsV2
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

            Console.WriteLine(numbers.Sum() > 20 ? 0 : numbers.Sum());
        }
    }
}
