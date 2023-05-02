using System;

namespace second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//input
            string[] strArray = input.Split(" ");//input to string array
            int[] array = Array.ConvertAll(strArray, int.Parse);//string array to int array

            //sorting the numbers small to large
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
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

            //removingthe duplicates
            int size = array.Length;

            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] == array[j])
                    {
                        for (int k = j; k < size - 1; k++)
                        {
                            array[k] = array[k + 1];
                        }
                        j--;
                        size--;
                    }
                }
            }
            
            //printing the second largest value
            int second = array[size-1-1];
            Console.WriteLine(second);
        }
    }
}

 