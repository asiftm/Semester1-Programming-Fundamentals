using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string[] input = Console.ReadLine().Split(' ');
                
                string store = string.Empty;
                foreach (string number in input)
                {
                   
                    char letter = 'A';
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= 5; j++)
                        {
                            if (number == (i.ToString() + j.ToString()))
                            {
                                
                                store = store + letter + " ";
                               
                            }
                            

                            letter++;
                        }

                    }
                }
                store.Trim();
                if (input.Length*2==store.Length)
                {
                    Console.WriteLine(store);
                }
                else
                {
                    Console.WriteLine("crezy");
                }
            }

            catch (Exception)
            {

                Console.WriteLine("crezy");
            }
        }
    }
}
