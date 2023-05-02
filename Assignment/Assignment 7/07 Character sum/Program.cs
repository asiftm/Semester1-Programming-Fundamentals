using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Character_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                int characterSum = Convert.ToInt32(Console.ReadLine());
                
                string output = string.Empty;

                StreamReader fileName = File.OpenText(input);
                string text = fileName.ReadToEnd();
                fileName.Close();

                Regex pattern = new Regex(@"\b[a-z]{1,}\b");
                MatchCollection matches = pattern.Matches(text);

                int count = matches.Count;
                
                foreach (Match item in matches)
                {
                    string word = item.ToString();

                    int wordSum = 0;

                    for (int j = 0; j < word.Length; j++)
                    {
                        char ascii = (word[j]);

                        wordSum += ascii - 96;
                    }
                    if (wordSum == characterSum)
                    {
                        if (!output.Contains(word))
                        {
                            output += word + " ";
                        }
                    }
                }
                Console.WriteLine(output);
            }

            catch (FormatException)
            {
                Console.WriteLine("converting problem");
            }
            catch(OverflowException)
            {
                Console.WriteLine("too big for this type");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("file not found");
            }
            catch(Exception)
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
