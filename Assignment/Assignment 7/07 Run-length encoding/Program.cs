using System;

namespace Run_length_encoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                int count = 1;

                string output = string.Empty;

                bool alphabet = false;

                for (int i = 0; i < input.Length; i++) //input is alphabet or not
                {
                    char a = Convert.ToChar(input[i]);

                    if ((a > 64 && a < 91)||(a > 96 && a < 123))
                    {
                        alphabet = true;
                    }

                    else
                    {
                        alphabet = false;
                        break;
                    }
                }

                if (alphabet==true)
                {
                    //actual code
                    input = input + " ";
                    for (int i = 0; i < input.Length - 1; i++)
                    {
                        if (input[i] == input[i + 1])
                        {
                            count++;
                        }
                        else
                        {
                            if (count == 1)
                            {
                                output += input[i];
                            }
                            else
                            {
                                output += count + input[i].ToString();
                                count = 1;
                            }
                        }
                    }
                    Console.WriteLine(output);
                }
                else
                {
                    Console.WriteLine("crazy input");
                }
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
