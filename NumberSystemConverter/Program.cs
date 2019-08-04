using System;
using System.Collections.Generic;

namespace NumberSystemConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the text you wanted to convert : ");
            string text = Console.ReadLine().Trim();

            if (!String.IsNullOrEmpty(text))
            {
                PrintBinaryFormat(text);
            }

            else
            {
                Console.WriteLine("Enter valid text.");
            }

            Console.ReadLine();
        }

        private static void PrintBinaryFormat(string text)
        {
            foreach (string item in ConvertTextDecimalToBinary(text))
            {
                Console.WriteLine(item);
            }
        }

        private static List<string> ConvertTextDecimalToBinary(string text)
        {
            List<string> stringList = new List<string>();

            foreach (char c in text)
            {
                stringList.Add(ConvertCharDecimalToBinary(c));
            }

            return stringList;
        }

        private static string ConvertCharDecimalToBinary(char c)
        {
            string reverseResult = String.Empty;

            int asciiNumb = Convert.ToInt32(c);

            while (asciiNumb != 0)
            {
                reverseResult += Convert.ToString(asciiNumb % 2);
                asciiNumb /= 2;
            }

            return new string(ReverseString(reverseResult.PadRight(8, '0')));
        }

        private static string ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
