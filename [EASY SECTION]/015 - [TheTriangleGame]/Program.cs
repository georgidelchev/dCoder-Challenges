using System;

namespace TheTriangleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(word[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
