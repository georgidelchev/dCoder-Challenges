using System;
using System.Linq;

namespace LearningFactorialsWithLoopRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int fact = Enumerable.Range(1, number).Aggregate((acc, x) => acc * x);
            Console.WriteLine(fact);
        }
    }
}
