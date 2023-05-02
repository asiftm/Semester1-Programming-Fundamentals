using System;
using System.IO;

namespace Longest_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            string input = Console.ReadLine();

            //raeding the file
            StreamReader read = File.OpenText(input);
            string text = read.ReadToEnd();
            read.Close();

            //replacing the special characters
            string newText = text.Replace(";", " ");

            //making an array of words
            string[] array = newText.Split(" ");
            
            //variables for next steps
            int length1 = 0;
            int longest = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int length = array[i].Length;

                if(length > length1)
                {
                    length1 = length;

                    longest = i;
                }
            }
            Console.WriteLine(array[longest]);
        }
    }
}
