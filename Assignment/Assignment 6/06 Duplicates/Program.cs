using System;

namespace Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reading the input
            string input = Console.ReadLine();

            //making an array
            string[] array = input.Split(" ");

            //new variables
            string store = string.Empty;
            int count = 0;

            for (int i = 0; i < array.Length; i++)//putting the array values into the loop
            {
                if (!store.Contains(array[i]))//cheching if they're not duplicates
                {
                    store =store +" "+ array[i];
                }
                else//count the duplicates
                {
                    count++;
                }
            }
            //output
            Console.WriteLine(count);
        } 
    }
}
