using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz28._02._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string -> ");
            string input = Console.ReadLine().ToLower();

            int vowelCount = 0;
            int consonantCount = 0;
            int wordCount = 0;
            int punctuationCount = 0;
            int digitCount = 0;
            int otherCount = 0;

            foreach (char c in input)
            {
                if (Char.IsLetter(c))
                {
                    if ("aeiou".IndexOf(c) != -1)
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
                else if (Char.IsWhiteSpace(c))
                {
                    wordCount++;
                }
                else if (Char.IsPunctuation(c))
                {
                    punctuationCount++;
                }
                else if (Char.IsDigit(c))
                {
                    digitCount++;
                }
                else
                {
                    otherCount++;
                }
            }

            Console.WriteLine("Number of words -> {0}", (wordCount + 1));
            Console.WriteLine("Number of vowels -> {0}",vowelCount);
            Console.WriteLine("Number of consonants -> {0}",consonantCount);
            Console.WriteLine("Number of punctuation marks -> {0}",punctuationCount);
            Console.WriteLine("Number of digits -> {0}",digitCount);
            Console.WriteLine("Number of other symbols -> {0}", otherCount);
        }
    }
}
