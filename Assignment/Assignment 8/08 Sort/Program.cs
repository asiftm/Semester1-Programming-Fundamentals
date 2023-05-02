using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                input = input.Replace(" ,", ",");
                input = input.Replace(", ", ",");

                string[] strings = input.Split(",");

                Array.Sort(strings);

                Dictionary<string, string> dict = new Dictionary<string, string>();

                for (int i = 0; i < strings.Length; i++)
                {
                    string[] name = strings[i].Split(" ");

                    string firstName = name[0].ToString();

                    string lastName = string.Empty;

                    for (int j = 1; j < name.Length; j++)
                    {
                        lastName = lastName + " " + name[j].ToString();
                    }

                    dict.Add(firstName, lastName);
                }

                var sorted = from data in dict orderby data.Key ascending select data;

                foreach (var item in sorted)
                {
                    Console.WriteLine(item.Key + item.Value);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
