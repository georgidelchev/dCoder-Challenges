using System;
using System.Linq;

namespace AvikAndHisGirlfriendNecklace
{
    class Program
    {
        static void Main(string[] args)
        {
            int pearlsCount = int.Parse(Console.ReadLine());
            int[] pearlsNumbers = new int[pearlsCount - 1];

            pearlsNumbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Array.Sort(pearlsNumbers);

            foreach (var values in pearlsNumbers)
            {
                Console.Write($"{values} ");
            }
        }
    }
}
