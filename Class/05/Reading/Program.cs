using System;
using System.IO;
using System.Text.RegularExpressions;


namespace Reading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* entire file
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            input.Close();
            Console.WriteLine(text);
            */

            /* line byline
            StreamReader input = File.OpenText("Rapunzel.txt");
            string line = input.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = input.ReadLine();
            }

            input.Close();
            */

            /* character by character
            StreamReader input = File.OpenText("Rapunzel.txt");

            int amount = 0;
            while (!input.EndOfStream)
            {
                char c = (char)input.Read();
                amount++;
               // Console.WriteLine(c + "(" + amount + ") ");
            }
            Console.WriteLine($"rupanzel has {amount} characters! ");
            */

            /* first 5 line
            StreamReader input = File.OpenText("Rapunzel.txt");
            string line;
            int a = 5;
            for (int i=0;i<5;i++)
            {
                line = input.ReadLine();
                Console.WriteLine(line);
            }

            input.Close();
            */

            /* character by character
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            input.Close();

            //Console.WriteLine(text);

            foreach (char c in text)
            {
                Console.WriteLine(c);
            }
            */

            /* upper case
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            input.Close();
            Console.WriteLine(text.ToUpper());
            */

            
            //read in the text
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            input.Close();

            //making searching pattern
            Regex mypattern = new Regex(@"Rapunzel",RegexOptions.IgnoreCase);

            //searching fo matching
            MatchCollection matches = mypattern.Matches(text);
            //count and print
            Console.WriteLine($"the word rupunzel occurs {matches.Count} times");
            

        }
    }
}
