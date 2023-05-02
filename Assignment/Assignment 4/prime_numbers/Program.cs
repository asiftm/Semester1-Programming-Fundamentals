using System;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                
                
                int n = int.Parse(Console.ReadLine());
                if(n>1)
                {
                    for (int num = 2; num <= n; num++)
                    {
                        bool prime = true;
                        int divider = 2;
                        int maxDivider = (int)Math.Sqrt(num);
                        while (divider <= maxDivider)
                        {
                            if (num % divider == 0)
                            {
                                prime = false;
                                break;
                            }
                            divider++;
                        }
                        if (prime)
                        {
                            Console.Write(num+" ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("crazy input");
                }
                
            }
        }
    }
}
