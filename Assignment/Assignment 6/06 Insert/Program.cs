using System;

namespace Insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputArray = Console.ReadLine();//reading an array
            string aValue = Console.ReadLine();//reading a value

            string allValue = inputArray + " " + aValue;//adding all the values

            string[] newArray = allValue.Split(" "); //making an array

            int[] array = Array.ConvertAll(newArray, int.Parse);//converting to int
             
            int temp = 0;

            for (int i = 0; i <array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
