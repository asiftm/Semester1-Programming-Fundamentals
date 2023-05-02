using System;

namespace zero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();

                string[] array = input.Split(" ");

                int num1 = Convert.ToInt32(array[0]);
                int num2 = Convert.ToInt32(array[1]);

                int tempSum =  num1 + num2;
                int temp1 = 0;
                int temp2 = 0;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        num1 = Convert.ToInt32(array[i]);
                        num2 = Convert.ToInt32(array[j]);

                        int sum = num1 + num2 ;

                        if (tempSum < 0)
                        {
                            tempSum = tempSum * -1;
                        }

                        if (sum>=0 && tempSum > sum)
                        {
                            tempSum = sum;
                            temp1 = i;
                            temp2 = j;
                        }
                    }
                }
                Console.WriteLine($"{tempSum}\n{array[temp1]} {array[temp2]}");
            }
            catch(Exception)
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
