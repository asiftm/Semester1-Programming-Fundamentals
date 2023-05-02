using System;
using System.Net.Mail;
using System.Text;

namespace sadman_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a tesT");
            string word = Console.ReadLine().Replace(" ", "");
           
            int length = word.Length;
            char[] words = word.ToCharArray();

            foreach (var item in words)
            {
                
                if(item>=65 && item<=90 )
                {
                    string x = item.ToString();
                    string items = x.ToLower();
                    Console.WriteLine(items);
                }
                else if (item >= 97 && item <= 122)
                {
                    string x = item.ToString();
                    string items = x.ToUpper();
                    Console.WriteLine(items);
                }


            }


        }
    }
}
