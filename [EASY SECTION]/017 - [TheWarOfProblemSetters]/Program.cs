using System;
using System.Linq;

namespace TheWarOfProblemSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] garrysPoints = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int garrysSum = garrysPoints.Sum();

            int[] sharrysPoints = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sharrysSum = sharrysPoints.Sum();

            if (garrysSum > sharrysSum)
            {
                double diff = garrysSum - sharrysSum;
                Console.WriteLine($"Garry {diff}");
            }
            else if (sharrysSum > garrysSum)
            {
                double diff = sharrysSum - garrysSum;
                Console.WriteLine($"Sharry {diff}");
            }
            else
            {
                Console.WriteLine("None 0");
            }
        }
    }
}
