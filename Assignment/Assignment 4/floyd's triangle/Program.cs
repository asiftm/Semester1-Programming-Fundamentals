using System;

namespace floyd_s_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int num = 1;
            
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <= i; j++)
                {   
                    Console.Write($"{num} ");

                    num = num+1;
                }

                Console.Write($"\n");
            }
        }
    }
}
