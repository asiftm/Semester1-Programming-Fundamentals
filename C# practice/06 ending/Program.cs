using System;
using System.Text;

namespace _06_ending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = "beginning ending".Split(" ");

            string newWord = string.Empty;

            string firstWord = words[0];
            string secondWord = words[1];

            for (int i = 0; i <firstWord.Length; i++)
            {
                for (int j = 0;j< secondWord.Length;j++)
                {
                    if (firstWord[i] == secondWord[j])
                    {
                        newWord = newWord + firstWord[i];
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                break;
            }
        }
    }
}
