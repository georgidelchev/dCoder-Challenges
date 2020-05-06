using System;

namespace SquareOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool flag = false;
            Math.Abs(number);
            for (int i = 2; i < number; i++)
            {
                if ((number / i == i) && (number % i == 0))
                {
                    flag = true;
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
