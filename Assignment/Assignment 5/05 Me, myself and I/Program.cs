using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Me__myself_and_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string inputWithoutSpace =input.Trim().Replace(" ", "");
            string file = new string(inputWithoutSpace +".txt");

            StreamReader read = File.OpenText(file);
            string text = read.ReadToEnd();
            read.Close();

            string lower = input.ToLower();
            Regex mypattern = new Regex(lower);
            MatchCollection matches = mypattern.Matches(text);

            Console.WriteLine($"{matches.Count} occurrences of {input}");
        }
    }
}
