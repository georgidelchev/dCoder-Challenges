using System;

namespace HowManyWeeks
{
    class Program
    {
        static void Main(string[] args)
        {
            int weeklyWaterUsage = int.Parse(Console.ReadLine());
            int gallonsTheyHave = 10000;
            int totalWeeks = gallonsTheyHave / weeklyWaterUsage;
            Console.WriteLine(totalWeeks);
        }
    }
}
