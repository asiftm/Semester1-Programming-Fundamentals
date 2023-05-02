using System;
using System.IO;
using System.Text.RegularExpressions;

namespace word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string specificCharacters = Console.ReadLine();
                int outputLength = Convert.ToInt32(Console.ReadLine());

                StreamReader fileName = File.OpenText(input);
                string text = fileName.ReadToEnd();
                fileName.Close();

                Regex pattern = new Regex(@"\b[a-z]{0,}\b");
                MatchCollection matches = pattern.Matches(text);

                string output = string.Empty;

                bool state = false;

                foreach (var item in matches)
                {
                    string words = item.ToString();

                    if ((!output.Contains(words)) && (words.Length == outputLength))//unique words and specific length
                    {
                        
                        for (int i = 0; i < specificCharacters.Length; i++)//specific Characters present or not 
                        {
                            if (words.Contains(specificCharacters[i]))
                            {
                                state = true;
                            }
                            else
                            {
                                state = false;
                                break;
                            }
                        }
                        if (state == true)
                        {
                            output = output + words + " ";
                        }
                        
                    }
                }
                Console.WriteLine(output);
            }
    
            catch(FormatException)
            {
                Console.WriteLine("converting problem");
            }
            catch (OverflowException)
            {
                Console.WriteLine("'too big for this type");
            }
            catch(FileNotFoundException)
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
