using System;

namespace Word_Nest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "code";
            string nest = "cocodccococodededeodeede";

            int count = 0;

            for(int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < nest.Length; j++)
                {
                    if(word[i] == nest[j])
                    {
                        count++;
                        Console.WriteLine(word[i]);
                    }
                }
                //if (nest.Contains(word[i]))
                //{
                //count++;
                //Console.WriteLine(word[i]);
                //}
            }
            Console.WriteLine(count);
        }
    }
}
