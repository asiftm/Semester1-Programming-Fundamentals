using System;
using System.IO;

namespace Count
{
    internal class Program
    {
        static void Main(string[] args)
        {   //reading an input
            string input = Console.ReadLine();

            //excluding space by replacing them
            string text = input.Trim().Replace(" ","");

            //declare variables
            int vowel = 0, consonent = 0, digit = 0, other = 0;

            //loop
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if ((ch >='a' && ch <= 'z')||(ch >= 'A' && ch <= 'Z') ) //alphabet
                {
                    if(ch=='a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U') 
                    {
                        vowel++;
                    }
                    else
                    {
                        consonent++;
                    }
                }
                else if(ch >= '0' && ch <= '9')
                {
                    digit++;
                }
                else
                {
                    other++;
                }
            }
            Console.WriteLine($"consonants: {consonent}\nvowels: {vowel}\ndigits: {digit}\nother: {other}");
        }
    }
}
