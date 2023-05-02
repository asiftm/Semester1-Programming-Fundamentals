using System;
using System.IO;
using System.Text.RegularExpressions;


namespace files01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter stream = File.CreateText("file.txt");
            //stream.WriteLine("this is a test file");
            //stream.Close()


            //string path = Path.Combine(@"C:\Users\WALTON\Desktop\Programming Fundamentals\C# practice", "file.txt");
            //StreamWriter stream = File.CreateText(path);
            //stream.WriteLine("new path");
            //stream.Close();


            //string path = Path.Combine(@"C:\Users\WALTON\Desktop\Programming Fundamentals\C# practice", "file.txt");
            //if(File.Exists(path))
            //{
            //    StreamWriter output=File.AppendText(path);
            //    output.WriteLine("New test line");
            //    output.Close();
            //}


            //string path = Path.Combine(@"C:\Users\WALTON\Desktop\Programming Fundamentals\C# practice", "file.txt");
            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}

            //StreamReader input = File.OpenText("Rapunzel.txt");
            //string text = input.ReadToEnd();
            //Console.Write(text);
            //input.Close();

            //StreamReader input = File.OpenText("Rapunzel.txt");
            //string line = input.ReadLine();
            //while(line != null)
            //{
            //    Console.WriteLine(line);
            //    line = input.ReadLine();
            //}
            //input.Close();

            //StreamReader input = File.OpenText("Rapunzel.txt");
            //while(!input.EndOfStream)
            //{
            //    char c = (char)input.Read();
            //    Console.Write(c+" ");
            //}
            //input.Close();

            //StreamReader input = File.OpenText("Rapunzel.txt");
            //int amount = 0;
            //while (!input.EndOfStream)
            //{
            //    char c = (char)input.Read();
            //    amount++;
            //    Console.Write(c + " ");
            //}
            //Console.WriteLine(amount);
            //input.Close();

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
