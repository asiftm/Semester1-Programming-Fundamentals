using System;

namespace _07_exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int hiddenNumber = 5;
            
            int input;

            string answer;

            Console.WriteLine("guess a number");

            //answer = Console.ReadLine();
            //input = Convert.ToInt32(Console.ReadLine());


            //while(input !=hiddenNumber)
            //{
            //    Console.WriteLine("nope,guess again");
            //    input=Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"Correct! the number is {input}");

            //successsfully converted
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
                while(input != hiddenNumber)
                {
                    Console.WriteLine("nope,guess again");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"Correct! the number is {input}");
            }
            catch(Exception e)
            {
                Console.WriteLine("not an int");
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
