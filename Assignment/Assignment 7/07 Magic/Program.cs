using System;

namespace Magic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int rowNumber =Convert.ToInt32(Console.ReadLine());

                int[,] array = new int[rowNumber , 100];

                int a = 0;
                int b = 0;
                int c = 0;
                int inputLength = 0;

                for (int i = 0; i < rowNumber; i++)
                {
                    string input = Console.ReadLine();
                    inputLength = input.Length;
                    string[] row = input.Split(" ");

                    for (int j = 0; j < row.Length; j++)
                    {
                        array[b, c] = int.Parse(row[a]);
                        c++;
                        a++;
                    }
                    a = 0;
                    c = 0;
                    b++;
                }

                bool magic = false;
                int firstColSum = 0; 

                for (int i = 0; i < rowNumber; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        firstColSum = firstColSum + array[i, j];
                    }
                }

                int arrayLength = (inputLength + 1) / 2;
                int allColSum = 0;

                for (int j = 0; j < arrayLength; j++)
                {
                    for (int k = 0; k < rowNumber; k++)
                    {
                        allColSum = allColSum + array[k, j];
                    }

                    if (allColSum == firstColSum)
                    {
                        magic = true;
                    }
                    else
                    {
                        magic = false;
                        break;
                    }
                    allColSum = 0;
                }

                if (magic == true)
                {
                    Console.WriteLine("It's magic!");
                }
                else
                {
                    Console.WriteLine("No magic here!");
                }

            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("index out of range");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("don't divide by zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("not the right format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("just too much");
            }
            catch(Exception)
            {
                Console.WriteLine("crazy input");
            }

        }
    }
}
