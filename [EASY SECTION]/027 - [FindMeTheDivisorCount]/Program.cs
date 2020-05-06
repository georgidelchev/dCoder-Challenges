using System;
using System.Linq;

namespace FindMeTheDivisorCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstNumber = arr[0];
            int secondNumber = arr[1];
            int thirdNumber = arr[2];

            int counter = 0;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if ((i % thirdNumber) == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
