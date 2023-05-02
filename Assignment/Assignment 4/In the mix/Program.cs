using System;
using System.Linq;

namespace In_the_mix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();

            int length1 = string1.Length;
            int length2 = string2.Length;

            if((length1 > length2) || (length1 == length2))
            {
                for (int i = 0; i < string1.Length; i++)

                {
                    Console.Write(string1.ElementAt(i));

                    for (int j = i; j < string2.Length; j++)
                    {

                        Console.Write(string2.ElementAt(j));
                        break;

                    }
                }
            }

            
            else
            {
                for (int i = 0; i < string2.Length; i++)

                {
                    Console.Write(string2.ElementAt(i));

                    for (int j = i; j < string1.Length; j++)
                    {

                        Console.Write(string1.ElementAt(j));
                        break;

                    }
                }
            }

                
        }
    }
}
