using System;
using System.Collections.Generic;

namespace collections01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays
            int[] myArray1 = { 12, 8, 19 };
            int[] myArray2 = new int[3];


            //lists
            List<string> myList1= new List<string>();

            myList1.Add("a");
            myList1.Add("b");  
            myList1.Add("22");

            myList1.Add("d");
            myList1.Insert(1, "s");
            //myList1.Remove("a");
            //myList1.RemoveAt(3);

            //asb22d
            myList1.RemoveAt(2);
            myList1.Insert(2, "w");
            for (int i = 0; i <myList1.Count; i++)
            {
                Console.WriteLine(myList1[i]);
            }

            Console.WriteLine(myList1.IndexOf("22"));
            




        }
    }
}

