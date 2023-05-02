using System;


namespace polybius2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[,] square =  {
                                        {"A" , "B" ,  "C"  , "D"   , "E" },
                                        { "F" , "G" ,  "H"  , "I"   , "J" },
                                        { "K","L" , "M" ,  "N"  , "O"   },
                                        {"P","Q","R" , "S" ,  "T"   },
                                        {"U"   , "V", "W" ,"x" ,"Y"}
                                    };

                String input = Console.ReadLine();
                string[] inputArray = input.Split(" ");

                for (int i = 0; i < inputArray.Length; i++)
                {

                    string num = inputArray[i];

                    if(num=="A" || num == "B" || num == "C" || num == "D" || num == "E" || num == "F" || num == "G" || num == "H" || num == "I" || num == "J" || num == "K" || num == "L" || num == "M" || num == "N" || num == "O" || num == "P" || num == "Q" || num == "R" || num == "S" || num == "T" || num == "U" || num == "V" || num == "W" || num == "X" || num == "Y" || num == "Z")
                    {
                        Console.WriteLine("index out of range");
                        return;
                    }
                    else
                    {
                        int index0 = Convert.ToInt32(num[0].ToString()) - 1;
                        int index1 = Convert.ToInt32(num[1].ToString()) - 1;

                        string alp = square[index0, index1];

                        Console.Write(alp + " ");
                    }

                    
                }
            }
            catch (IndexOutOfRangeException)
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
