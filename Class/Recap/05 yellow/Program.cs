using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace _05_yellow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hexaColor = Console.ReadLine();

            try
            {
                int hexNumber = Convert.ToInt32(hexaColor, 16);

                Color mycolor = ColorTranslator.FromOle(hexNumber);

                //Console.WriteLine(mycolor.Name);

                if (mycolor.IsKnownColor)
                {
                    Regex regex = new Regex(@"\b" + mycolor.Name + @"\b", RegexOptions.IgnoreCase);
                    string text = File.ReadAllText("ColdPlay.txt");
                    MatchCollection matches = regex.Matches(text);

                    if (matches.Count > 0)
                    {
                        Console.WriteLine($"It was all {mycolor.Name} ({matches.Count} matches)");
                    }
                    else
                    {
                        Console.WriteLine($"It wasn't {mycolor.Name} at all");
                    }
                }
                else
                {
                    Console.WriteLine("It was just colorless");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("wrong input");
            }

            

            

        }
    }
}
