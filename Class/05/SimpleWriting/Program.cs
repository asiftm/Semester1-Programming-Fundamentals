using System;
using System.IO;

namespace SimpleWriting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            StreamWriter stream=File.CreateText("hello_world.txt");
            stream.WriteLine("Hello World!");
            stream.Write("Hello!");
            stream.Close();
            */

            /*
            string path = Path.Combine(@"C:\Users\WALTON\Desktop\Programming Fundamentals\Class\05", "file.txt");

            StreamWriter stream = File.CreateText(path);

            stream.WriteLine("Test!");

            stream.Close();
            */

            /*
            string path = Path.Combine(@"C:\Users\WALTON\Desktop\Programming Fundamentals\Class\05", "file.txt");
            if (File.Exists(path))
            {
                StreamWriter output = File.AppendText(path);
                output.WriteLine("appended!");
                output.Close();
            }
            */


            
            

        }
    }
}
