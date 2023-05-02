using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //open a file, read the full text and close
            StreamReader reader = File.OpenText("Beyonce.txt");
            string text = reader.ReadToEnd();
            reader.Close();

            //pattern for year and date
            Regex yearsAndDates = new Regex(@"\b\d{4}|-\d{2}-\d{2}\b");
            MatchCollection matches1 = yearsAndDates.Matches(text);

            int count = 0;

            foreach(Match match1 in matches1)
            {
                count++;
                text = text.Replace(match1.Value, "");//replacing the dates and years
                Console.WriteLine(match1.Value);
            }

            //Console.WriteLine(text);

            //Console.WriteLine("count"+count);

            //new pattern for remaining numbers
            Regex numbers = new Regex(@"\d+");
            MatchCollection matches2 = numbers.Matches(text);

            int sum = 0;

            foreach (Match match2 in matches2)
            {
                sum=sum+int.Parse(match2.Value);//adding the matched values
                Console.WriteLine(match2.Value);
            }

            //output
            Console.WriteLine(sum);
        }
    }
}
