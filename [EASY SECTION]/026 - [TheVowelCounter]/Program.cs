using System;

namespace TheVowelCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int totalVowelsCounter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')||
                    (str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U'))
                {
                    totalVowelsCounter++;
                }
            }
            Console.WriteLine(totalVowelsCounter);
        }
    }
}
