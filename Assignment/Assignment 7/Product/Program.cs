using System;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 10;

            string box = string.Empty;

            for (int i = 1; i <input; i++)
            {
                int reminder = input % i;
                if(reminder == 0)
                {
                    
                    for (int j = 1; j <= i; j++)
                    {

                        reminder = i % j;

                        if(reminder == 0)
                        {
                            if (j > 2)
                            {
                                box = box + i + " ";
                            }
                        }
                        else
                        {
                            box = box + i + " ";
                        }

                    }
                    
                }
            }

            Console.WriteLine(box);
            



        }
    }
}
