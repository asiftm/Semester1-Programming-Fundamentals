using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Single_Ladies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = File.OpenText(Console.ReadLine());
            string text = input.ReadToEnd();
            input.Close();

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            string lower = text.ToLower();

            string[] words = lower.Split(" ");

            //girl

            Regex patternGirl = new Regex(@"\bgirl\b", RegexOptions.IgnoreCase);
            MatchCollection matchesGirl = patternGirl.Matches(text);

            Regex patternGirls = new Regex(@"\bgirls\b", RegexOptions.IgnoreCase);
            MatchCollection matchesGirls = patternGirls.Matches(text);

            count1 = matchesGirl.Count + matchesGirls.Count;

            Console.WriteLine($"girl/girls: {count1} matches found");

            //lady
            Regex pattern2 = new Regex(@"\blad(y|ies)\b");

            for (int i = 0; i < words.Length; i++)
            {
                Match match = pattern2.Match(words[i]);

                if (match.Success)
                {
                    count2++;
                }
            }
            Console.WriteLine($"lady/ladies: {count2} matches found");

            //woman
            Regex pattern3 = new Regex(@"\bwom(an|en)\b");

            for (int i = 0; i < words.Length; i++)
            {
                Match match = pattern3.Match(words[i]);

                if (match.Success)
                {
                    count3++;
                }
            }
            Console.WriteLine($"woman/women: {count3} matches found");
        }
    }
}