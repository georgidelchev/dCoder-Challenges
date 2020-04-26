using System;
using System.Linq;

namespace TheSumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayElementsCount = int.Parse(Console.ReadLine());
            int[] array = new int[arrayElementsCount - 1];

            array = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(array.Sum());
        }
    }
}
