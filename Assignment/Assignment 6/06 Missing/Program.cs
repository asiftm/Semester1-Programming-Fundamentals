using System;

namespace Missing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            string input = Console.ReadLine();
            string[] strArray = input.Split(" ");
            int[] array = Array.ConvertAll(strArray, int.Parse);

            //finding the largest value
            int largest = 0;

            for (int i = 0; i < array.Length; i++)
            {
                while (array[i] > largest)
                {
                    largest = array[i];
                }
            }

            //finding the smallest value
            int smallest = largest - array.Length;

            //calculating estimated total
            int sum = 0;

            for (int i = 0; i <= array.Length; i++)
            {
                sum=sum+smallest;
                smallest++;
            }

            //calculating actual total
            int arraySum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                arraySum=arraySum+array[i];
            }
           
            //the missing value
            int missing = sum - arraySum;

            //output
            if(missing == 0)
            {
                Console.WriteLine("There is no missing link!");
            }
            else
            {
                Console.WriteLine(missing);
            }
        }
    }
}