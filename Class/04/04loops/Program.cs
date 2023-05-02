using System;

namespace _04loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                for (int i = -10; i < 10; i++) ;
                {
                    Console.WriteLine(11+i);
                }
            */
           
            string answer = "asif";
            Console.WriteLine("guess my name");
            string input=Console.ReadLine();

            while (input != answer)
            {
                Console.WriteLine("guess my name");
                input = Console.ReadLine();
            }
            Console.WriteLine("you god damn right");
            



        }
    }
}
