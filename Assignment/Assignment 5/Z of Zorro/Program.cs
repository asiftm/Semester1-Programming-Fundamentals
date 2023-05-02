using System;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;

namespace Z_of_Zorro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String input = "SelenaGomez.txt";
            string text = File.ReadAllText(input).ToLower();

            Regex regex = new Regex(@"\b[a-z]+\b");

            MatchCollection match= regex.Matches(text);

            string output = "";

            foreach(Match m in match)
            {
                if(m.Value.Contains('z'))
                {
                    if(!output.Contains(m.Value))
                    {
                        regex = new Regex(@"\b" + m.Value + @"\b");

                        if(regex.Matches(output).Count==0)
                        {
                            output = output + m.Value + " ";
                        }

                        

                        
                    }
                }  
            }
            Console.WriteLine(output);
        }
    }
}
