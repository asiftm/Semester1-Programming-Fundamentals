using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dic1 = new Dictionary<int, string>();

            dic1.Add(3,"asif");
            dic1.Add(1,"asi");
            dic1.Add(2,"as");
            dic1.Add(5,"a");
            dic1.Add(6,"asiff");

            //Console.WriteLine("for loop");
            //for (int i = 0; i < dic1.Count; i++)
            //{
            //    Console.WriteLine(dic1.ElementAt(i));
            //}
            
            //Console.WriteLine("\nforeach");

            //foreach(var dic in dic1)
            //{
            //    Console.WriteLine(dic);
            //}

            //Console.WriteLine("\nvalues");
            //foreach (var value in dic1.Values)
            //{
            //    Console.WriteLine(value);
            //}

            //Console.WriteLine("\nkeys");
            //foreach (var key in dic1.Keys)
            //{
            //    Console.WriteLine(key);
            //}

            Console.WriteLine(dic1[3]);


        }
    }
}
