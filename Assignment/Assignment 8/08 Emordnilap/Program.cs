using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Emordnilap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine().ToLower();

                StreamReader reader = File.OpenText("english.txt");
                string text = reader.ReadToEnd().ToLower();
                reader.Close();

                Regex pattern = new Regex(@"\b[a-z]*\b");
                MatchCollection inputMatches = pattern.Matches(input);
                MatchCollection textMatches = pattern.Matches(text);

                string output = string.Empty;

                for (int i = 0; i < inputMatches.Count; i++)
                {
                    string word = inputMatches[i].ToString();

                    string reverse = string.Empty;

                    for (int j = word.Length - 1; j >= 0; j--)
                    {
                        reverse = reverse + word[j];
                    }
                    if (reverse.Length > 0)
                    {
                        for (int k = 0; k < textMatches.Count; k++)
                        {
                            if (textMatches[k].Length == reverse.Length)
                            {
                                if ((textMatches[k].ToString() == reverse) && (!output.Contains(word)))
                                {
                                    output = output + word + " ";
                                    break;
                                }
                            }
                        }
                    }
                }
                string[] outputArray = output.Trim().Split(" ");
                Array.Sort(outputArray);

                for (int i = 0; i < outputArray.Length; i++)
                {
                    Console.Write($"{outputArray[i]} ");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("crazy input");
            }
            

        }
    }
}
