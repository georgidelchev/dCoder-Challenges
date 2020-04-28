using System;

namespace LetsGetGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int greatestDivisor = int.MinValue;
            for (int i = 1; i <= 10; i++)
            {
                if (firstNumber % i == 0 && secondNumber % i == 0)
                {
                    if (i > greatestDivisor)
                    {
                        greatestDivisor = i;
                    }
                }
            }
            Console.WriteLine(greatestDivisor);
        }
    }
}
