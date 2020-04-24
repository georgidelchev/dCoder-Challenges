using System;

namespace LearningUserInputWithNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numberInput; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
