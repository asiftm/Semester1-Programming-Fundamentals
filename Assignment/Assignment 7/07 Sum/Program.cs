using System;

namespace Sum 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());

                int sum = 0;

                if (input > 1)
                {
                    for (int i = 0; i < input; i++)
                    {
                        sum = sum + (i * i);
                    }
                    Console.WriteLine(sum);
                }
                else if (input < 1)
                {
                    for (int i = 0; i > input; i--)
                    {
                        sum = sum + (i * i);
                    }
                    Console.WriteLine(sum);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("converting problem");
            }
            catch (OverflowException)
            {
                Console.WriteLine("too big for this type");
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }

        }
    }
}
