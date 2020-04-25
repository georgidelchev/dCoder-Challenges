using System;
using System.Linq;

namespace TheShortestPathAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .Select(n => Math.Pow(n, 2))
                .ToArray();

            double firstDestination = Math.Sqrt(input[0] + input[1]);
            double secondDestination = Math.Sqrt(input[2] + input[3]);

            if (firstDestination > secondDestination)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("A");
            }
        }
    }
}
