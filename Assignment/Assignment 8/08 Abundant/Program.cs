using System;

namespace Abundant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split(" ");

                int one = int.Parse(inputArray[0]);
                int two = int.Parse(inputArray[1]);

                if (one < two)
                {
                    int min = one;
                    int max = two;

                    string store = string.Empty;
                    int sum = 0;

                    for (int i = min; i <= max; i++)
                    {
                        sum = 0;

                        for (int j = (i - 1); j > 1; j--)
                        {
                            int extra = i % j;

                            if (extra == 0)
                            {
                                sum += j;
                            }
                        }
                        if (sum > i)
                        {
                            store = store + " " + i;
                        }
                    }

                    string[] array = store.Split(" ");

                    string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        string output = string.Empty;

                        for (int j = 1; j < array.Length; j++)
                        {
                            string num = array[j];

                            if (numbers[i] == num[0].ToString())
                            {
                                output = num + " ";
                                Console.Write(output);
                            }
                        }
                        if (output.Length > 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }

                else if (one > two)
                {
                    int min = two;
                    int max = one;

                    string store = string.Empty;
                    int sum = 0;

                    for (int i = min; i <= max; i++)
                    {
                        sum = 0;

                        for (int j = (i - 1); j > 1; j--)
                        {
                            int extra = i % j;

                            if (extra == 0)
                            {
                                sum += j;
                            }
                        }
                        if (sum > i)
                        {
                            store = store + " " + i;
                        }
                    }

                    string[] array = store.Split(" ");

                    string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        string output = string.Empty;

                        for (int j = 1; j < array.Length; j++)
                        {
                            string num = array[j];

                            if (numbers[i] == num[0].ToString())
                            {
                                output = num + " ";
                                Console.Write(output);
                            }
                        }
                        if(output.Length>0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
            catch(Exception)
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}


