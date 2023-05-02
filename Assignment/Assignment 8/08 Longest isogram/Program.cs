using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Longest_isogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string fileName = Console.ReadLine();
                StreamReader streamReader = File.OpenText(fileName);
                string text = streamReader.ReadToEnd();
                streamReader.Close();

                Regex regex = new Regex("([A-Za-z])\\w+");
                MatchCollection matches = regex.Matches(text);

                string box1 = string.Empty;

                foreach (Match match in matches)
                {
                    string word = (match.Value).ToLower();

                    string result = string.Empty;

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (!result.Contains(word[i]))
                        {
                            result += word[i];
                        }
                    }

                    int lengthOfWord = match.Value.Length;
                    int lengthOfResult = result.Length;

                    if (lengthOfWord == lengthOfResult)
                    {
                        box1 = box1 + word + " ";
                    }
                }

                string[] boxArray = box1.Split(" ");
                string output = string.Empty;
                int temp = 0;

                for (int i = 0; i < boxArray.Length - 2; i++)
                {
                    int length = boxArray[i].Length;

                    if (length > temp)
                    {
                        output = boxArray[i];
                        temp = length;
                    }
                }
                Console.WriteLine(output);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File Not Found");
            }
            catch(Exception)
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
