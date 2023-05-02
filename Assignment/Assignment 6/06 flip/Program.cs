using System;

namespace flip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();//first input
            string store = input1;

            for (int i = 1; i < input1.Length; i++)
            {   
                string input2 = Console.ReadLine();//asking for input untill its a square matrix
                store = store+" "+input2;
            }

            string[] array = store.Split(" ");//majing an array

            for (int i = array.Length - 1; i>=0; i--)
            {
                Console.WriteLine(array[i]); //printing the input values from down to up
            }
        }
    }
}
