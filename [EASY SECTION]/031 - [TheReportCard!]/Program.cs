using System;
using System.Linq;

namespace TheReportCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] points = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            double sum = points.Sum();
            sum /= 3;

            char grade = ' ';
            if (sum > 90 && sum <= 100)
            {
                grade = 'A';
            }
            else if (sum > 80 && sum <= 90)
            {
                grade = 'B';
            }
            else if (sum > 70 && sum <= 80)
            {
                grade = 'C';
            }
            else if (sum > 60 && sum <= 70)
            {
                grade = 'D';
            }
            else if (sum <= 60)
            {
                grade = 'F';
            }

            Console.WriteLine(grade);
        }
    }
}
