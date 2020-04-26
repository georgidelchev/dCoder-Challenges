using System;

namespace ToggleMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string convertedWord = string.Empty;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'A' && word[i] <= 'Z')
                {
                    convertedWord += Char.ToLower(word[i]);
                }
                else if (word[i] >= 'a' && word[i] <= 'z')
                {
                    convertedWord += Char.ToUpper(word[i]);
                }
                else
                {
                    convertedWord += word[i];
                }
            }
            
            Console.WriteLine(convertedWord);
        }
    }
}
