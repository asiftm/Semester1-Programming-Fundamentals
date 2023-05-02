using System;

namespace _04MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //make a multiplication table of 5!

            int input = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<11 ; i++ )
            {
                Console.WriteLine($"{input}*{i}={i*input}");
            }

        }
    }
}
