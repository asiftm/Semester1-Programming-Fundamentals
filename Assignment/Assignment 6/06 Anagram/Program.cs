using System;

namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string lower1 = input1.ToLower();
            string lower2 = input2.ToLower();

            string one = lower1.Replace(" ", "");
            string two = lower2.Replace(" ", "");

            int count = 0;

            for (int i = 0; i < one.Length; i++)
            {
                if (two.Contains(one[i]))
                {
                    count++;
                }
            }
            if ((count == one.Length) && (count == two.Length))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
