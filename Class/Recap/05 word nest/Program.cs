using System;
using System.Text.RegularExpressions;

namespace _05_word_nest
{
    internal class Program
    { 
        static void Main(string[] args)
        {   
            string word =Console.ReadLine();

            string wordnest = "cocodccococodededeodeede"; //perfect word nest

            int count = 0;

            while (wordnest.Length > word.Length)
            {
                wordnest=wordnest.Replace(word,"");

                count++;
            }

            Console.WriteLine(count);

            



        }
    }
}
