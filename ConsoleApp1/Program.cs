using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ascii = Convert.ToChar(Console.ReadLine());

            int x = Convert.ToInt32(ascii)+32;

            Console.WriteLine(Convert.ToChar(x));
        }
    }
}