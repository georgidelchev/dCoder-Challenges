using System;
using System.Linq;

namespace TheLightSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] combination = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int theLightBulbIsOn = 1;
            int theLightBulbIsOff = 0;

            if ((combination[0] == 1 && combination[1] == 0) ||
                (combination[0] == 0 && combination[1] == 1))
            {
                Console.WriteLine(theLightBulbIsOn);
            }
            else
            {
                Console.WriteLine(theLightBulbIsOff);
            }
        }
    }
}
