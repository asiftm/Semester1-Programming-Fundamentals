using System;
using System.Dynamic;

namespace odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = Convert.ToInt32(Console.ReadLine());

           int a = number % 2;

            if (a == 0)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

        }
    }
}
