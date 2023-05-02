using System;
using System.IO;
using System.Reflection.Metadata;

namespace Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                StreamReader read = File.OpenText(input);
                string text = read.ReadToEnd().ToLower();
                read.Close();

                string vowel = Vowel(text);
                Console.WriteLine($"vowel {vowel}");

                string consonant = Consonant(text);
                Console.WriteLine($"consonant {consonant}");
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
                
        }

        static string Vowel (string text)
        {
            string[] vowelArray = new string[] { "a", "e", "i", "o", "u" };

            int count = 0;
            int temp = 0;
            string vowel = string.Empty;
            for (int i = 0; i < vowelArray.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j].ToString() == vowelArray[i])
                    {
                        count++;
                        if (count > temp)
                        {
                            vowel = vowelArray[i];
                            temp = count;
                        }
                    }
                }
                count = 0;
            }
            return (vowel);
        }

        static string Consonant (string text)
        {
            string[] consonantArray = new string[] { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };

            int count = 0;
            int temp = 0;
            string consonant = string.Empty;
            for (int i = 0; i < consonantArray.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j].ToString() == consonantArray[i])
                    {
                        count++;
                        if (count > temp)
                        {
                            consonant = consonantArray[i];
                            temp = count;
                        }
                    }
                }
                count = 0;
            }
            return(consonant);
        }
    }
}
