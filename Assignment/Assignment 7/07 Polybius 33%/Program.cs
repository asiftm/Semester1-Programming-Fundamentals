using System;
using System.Collections.Generic;
using System.Linq;

namespace Polybius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<int, string> polybiusSquare = new Dictionary<int, string>();

                polybiusSquare.Add(11, "A");
                polybiusSquare.Add(12, "B");
                polybiusSquare.Add(13, "C");
                polybiusSquare.Add(14, "D");
                polybiusSquare.Add(15, "E");

                polybiusSquare.Add(21, "F");
                polybiusSquare.Add(22, "G");
                polybiusSquare.Add(23, "H");
                polybiusSquare.Add(24, "I");
                polybiusSquare.Add(25, "J");

                polybiusSquare.Add(31, "K");
                polybiusSquare.Add(32, "L");
                polybiusSquare.Add(33, "M");
                polybiusSquare.Add(34, "N");
                polybiusSquare.Add(35, "O");

                polybiusSquare.Add(41, "P");
                polybiusSquare.Add(42, "Q");
                polybiusSquare.Add(43, "R");
                polybiusSquare.Add(44, "S");
                polybiusSquare.Add(45, "T");

                polybiusSquare.Add(51, "U");
                polybiusSquare.Add(52, "V");
                polybiusSquare.Add(53, "W");
                polybiusSquare.Add(54, "X");
                polybiusSquare.Add(55, "Y");

                int[] array = { 11, 12, 13, 14, 15, 21, 22, 23, 24, 25, 31, 32, 33, 34, 35, 41, 42, 43, 44, 45, 51, 52, 53, 54, 55 };

                String input = Console.ReadLine();
                string[] inputArray = input.Split(" ");

                bool range = false;

                for (int i = 0; i < inputArray.Length; i++)
                {
                    int num = int.Parse(inputArray[i]);

                    if(array.Contains(num))
                    {
                        range= true;
                    }
                    else
                    {
                        range = false;
                        break;
                    }
                }

                if (range == true)
                {
                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        int num = int.Parse(inputArray[i]);

                        foreach (var key in polybiusSquare.Keys)
                        {
                            int keyNum = key;

                            if (keyNum == num)
                            {
                                Console.Write(polybiusSquare[num] + " ");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("index out of range");
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
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
