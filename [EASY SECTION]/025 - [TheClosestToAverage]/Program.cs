using System;
using System.Linq;

namespace TheClosestToAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrElements = int.Parse(Console.ReadLine());
            double[] arr = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            double sum = arr.Sum();
            int length = arr.Length;
            double average = sum / length;
            Console.WriteLine(Math.Round(average));
        }
    }
}
