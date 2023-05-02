using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Most_used_smallest_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = ReadFile();
            


            int smallestLength = SmallestLength(text);

            string allSmallestWords =AllSmallestWords( text.Replace(","," ") , smallestLength );

            string output = Output(allSmallestWords);

            Console.WriteLine(output);
        }
        static string ReadFile()
        {
            try
            {
                string input = Console.ReadLine();
                StreamReader streamReader = File.OpenText(input);
                string text = streamReader.ReadToEnd();
                streamReader.Close();
                return (text.ToLower());
            }
            catch(Exception)
            {
                return ("crazy input");
            }
        }
        static int SmallestLength (string input)
        {
            Regex pattern = new Regex("[a-z]\\w+");
            MatchCollection matches = pattern.Matches(input);

            int temp = 50;
            string store = string.Empty;

            foreach (Match match in matches)
            {
                int length = match.Value.Length;

                if (length < temp)
                {
                    store = match.Value;
                    temp = length;
                }
            }

            return (store.Length);
        }
        static string AllSmallestWords(string allSmallestWords, int length)
        {
            allSmallestWords = allSmallestWords.Replace(".", " ");

            string[] array = allSmallestWords.Split(" ");
            string store = string.Empty;
            bool condition = false;

            for (int i = 0; i < array.Length; i++)
            {
                string word = array[i].Trim();

                for (int j = 0; j < word.Length; j++)
                {
                    char latter = word[j];

                    if ((latter > 64 && latter < 91) || (latter > 96 && latter < 123))
                    {
                        condition = true;
                    }
                    else
                    {
                        condition = false;
                        break;

                    }
                }
                if (word.Length == length && condition == true)
                {
                    store = store + " " + word;
                }
            }

            return (store.Trim());
        }
        static string Output(string allSmallestWords)
        {
            string[] arrayy = allSmallestWords.Trim().Split(" ");
            int temp = 0;
            int count = 0;
            string output = null;

            for (int i = 0; i < arrayy.Length; i++)
            {
                for (int j = 0; j < arrayy.Length; j++)
                {
                    if (arrayy[i] == arrayy[j])
                    {
                        count++;
                    }
                }
                if (count > temp)
                {
                    output = arrayy[i];
                    temp = count;
                    count = 0;
                }
                else
                {
                    count = 0;
                }
            }
            return (output);
        }
    }
}
