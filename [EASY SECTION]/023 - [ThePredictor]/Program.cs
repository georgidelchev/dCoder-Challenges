using System;

namespace ThePredictor
{
    class Program
    {
        static void Main(string[] args)
        {
            string binaryNumber = Console.ReadLine();
            int zerosCounter = 0;
            int oneCounter = 0;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (Equals(binaryNumber[i].ToString(), "0"))
                {
                    zerosCounter++;
                }
                else if (Equals(binaryNumber[i].ToString(), "1"))
                {
                    oneCounter++;
                }
            }
            if (zerosCounter == 6 || oneCounter == 6)
            {
                Console.WriteLine("Bad");
            }
            else
            {
                Console.WriteLine("Good");
            }
        }
    }
}
