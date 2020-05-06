using System;

namespace IwillBeTheNext
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                int currentLetter = str[i] + 1;
                Console.Write((char)currentLetter);
            }
        }
    }
}
