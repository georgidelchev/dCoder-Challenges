using System;
using System.Globalization;
using System.Linq;

namespace CapitalizeMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console
                .ReadLine()
                .Split()
                .ToArray();
            
            TextInfo txtInfo = new CultureInfo("en-US", false).TextInfo;
            
            foreach (var item in str)
            {
                Console.Write($"{txtInfo.ToTitleCase(item)} ");
            }
        }
    }
}
