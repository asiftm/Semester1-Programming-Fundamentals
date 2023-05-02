using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Least_used_longest_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();

                StreamReader streamReader = File.OpenText(input);
                string text = streamReader.ReadToEnd();
                streamReader.Close();

                Regex regex = new Regex("[A-Za-z]\\w+");
                MatchCollection matches = regex.Matches(text);

                string usage = string.Empty;

                for (int i = 0; i < matches.Count; i++)
                {
                    string baseWord = matches[i].Value;
                    int count = 0;

                    for (int j = 0; j < matches.Count; j++)
                    {
                        string word = matches[j].Value;

                        if (baseWord == word)
                        {
                            count++;
                            if (count > 1)
                            {
                                break;
                            }
                        }
                    }
                    if (count == 1)
                    {
                        usage = usage + matches[i].Value + " ";
                    }
                }

                string[] usages = usage.Split(" ");

                int temp = 0;
                string longest = string.Empty;
                string store = string.Empty;

                for (int i = 0; i < usages.Length; i++)
                {
                    int length2 = usages[i].Length;

                    if (length2 > temp)
                    {
                        longest = usages[i];
                        temp = length2;
                    }
                }
                Console.WriteLine(longest.ToLower());
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File Not Found");
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
