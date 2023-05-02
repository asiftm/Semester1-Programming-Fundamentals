using System;

namespace number_of_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            int number = name.Length;
            
            Console.WriteLine($"{name}, your name has {number} characters");
            
        }
    }
}
