
using System;
using System.Runtime.Serialization;

namespace Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string dimensions = Console.ReadLine();
                dimensions = dimensions.Replace("x", " ");
                string[] dimensionsArray = dimensions.Split(" ");
                int[] rowColArray = Array.ConvertAll(dimensionsArray, int.Parse);

                int row1 = rowColArray[0];
                int column1 = rowColArray[1];
                int row2 = rowColArray[2];
                int column2 = rowColArray[3];


                string matrix1 = string.Empty;
                int readLine = 0;
                while(readLine<row1)
                {
                    matrix1 = matrix1 +" "+ Console.ReadLine();
                    
                    readLine++;
                }
                string[] matrix1Array = matrix1.Split(" ");

                string matrix2 = string.Empty;
                readLine = 0;
                while (readLine < row2)
                {
                    matrix2 = matrix2 + " " + Console.ReadLine();

                    readLine++;
                }
                string[] matrix2Array = matrix2.Split(" ");

                if (column1 == row2)
                {
                    int[,] matrixA = new int[row1, column1];
                    int index = 1;

                    for (int i = 0; i < row1; i++)
                    {
                        for (int j = 0; j < column1; j++)
                        {
                            matrixA[i, j] = int.Parse(matrix1Array[index]);
                            index++;
                        }
                    }

                    int[,] matrixB = new int[row2, column2];
                    index = 1;

                    for (int i = 0; i < row2; i++)
                    {
                        for (int j = 0; j < column2; j++)
                        {
                            matrixB[i, j] = int.Parse(matrix2Array[index]);
                            index++;
                        }
                    }

                    int[,] OutputMatrix = new int[row1, column2];
                    for (int i = 0; i < row1; i++)
                    {
                        for (int j = 0; j < column2; j++)
                        {
                            OutputMatrix[i, j] = 0;

                            for (int k = 0; k < column1; k++)
                            {
                                OutputMatrix[i, j] = OutputMatrix[i, j] + (matrixA[i, k] * matrixB[k, j]);
                            }
                        }
                    }


                    for (int i = 0; i < row1; i++)
                    {
                        for (int j = 0; j < column2; j++)
                        {
                            Console.Write(OutputMatrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("check your dimensions");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("index out of range");
            }
            catch (FormatException)
            {
                Console.WriteLine("converting problem");
            }
            catch (OverflowException)
            {
                Console.WriteLine("too big for this type");
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}