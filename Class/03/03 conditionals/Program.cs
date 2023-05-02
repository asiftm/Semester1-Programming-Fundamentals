using System;

namespace _03_conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (x<y)
                    {
                //if the condition is true
                        Console.WriteLine("x is smaller than y");

                     }
            else if (x==y)
                //if x and y are equal
                     {
                        Console.WriteLine("x is equal to y");
                     }
            else
                     {
                //if the condition is not true
                        Console.WriteLine("x is not smaller than y");
                     }
    

        }
    }
}