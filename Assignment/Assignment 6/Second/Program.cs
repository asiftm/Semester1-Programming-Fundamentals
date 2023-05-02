using System;

namespace Missing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            string input = "1 1 2 2 -1 -1";
            string[] strArray = input.Split(" ");
            int[] array = Array.ConvertAll(strArray, int.Parse);

            //sorting the numbers
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

            string sorted = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                sorted = sorted + " " + array[i];
            }

            Console.WriteLine("sorted"+sorted);

            //removing duplicates
            string[] sortedArray = sorted.Split(" ");

            string store = string.Empty;

            for (int i = 0; i <sortedArray.Length; i++)
            {
                for (int j =1; j < sortedArray.Length; j++)
                {
                    if (sortedArray[i] == sortedArray[j])
                    {
                        store = store +" "+ sortedArray[i];
                    }
                    break;
                }
            }




            //for (int i = 0; i < sortedArray.Length; i++)
            //{
            //    if (!store.Contains(sortedArray[i]))
            //    {
            //        Console.WriteLine("value"+sortedArray[i]);

            //        store = store + " " + sortedArray[i];
            //    }
            //}

            Console.WriteLine(store);

            //string[] resultArray = store.Split(" ");

            //Console.WriteLine(resultArray[resultArray.Length - 2]); ;


        }
    }
}

