using System;

namespace Isogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string text = input.ToLower();
            
            string result = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (!result.Contains(text[i]))
                {
                    result += text[i];
                }
            }

            int lengthOfInput = input.Length;
            int lengthOfResult = result.Length;

            Console.WriteLine(lengthOfInput==lengthOfResult);
        }
    }
}
