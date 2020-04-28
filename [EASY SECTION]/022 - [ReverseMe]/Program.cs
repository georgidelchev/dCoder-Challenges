using System;

namespace ReverseMe
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int leftPart = number;
            int reversedNumber = 0;
            while (leftPart > 0)
            {
                int a = leftPart % 10;
                reversedNumber = reversedNumber * 10 + a;
                leftPart = leftPart / 10;
            }
            Console.WriteLine(reversedNumber);
        }
    }
}
