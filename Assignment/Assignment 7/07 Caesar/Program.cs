using System;

namespace Caesar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int shift = int.Parse(Console.ReadLine());
                int constantShift = shift;

                string input = Console.ReadLine();
                string message = input.ToUpper();
               
                bool condition =false;

                for (int i = 0; i < message.Length; i++) //message is alphabet or not
                {
                    char a = Convert.ToChar(message[i]);

                    if(a>64 && a<91)
                    {
                        condition = true;
                    }

                    else
                    {
                        condition = false;
                    }
                }

                if(condition==true)
                {
                    for (int i = 0; i < message.Length; i++)
                    {
                        char character= Convert.ToChar(message[i]);

                        int ascii = Convert.ToInt32(character);
                        
                        int overflow = 0;

                        shift = constantShift;//shift should be equal for each char

                        if(shift>0) //positive shift
                        {
                            if (shift + ascii > 90) // overflow
                            {
                                overflow = shift + ascii - 90;

                                while(overflow>26)//actual shift or reducing overflow
                                {
                                    overflow = overflow + 64 - 90;
                                }

                                shift = 64 + overflow;

                                char ch = Convert.ToChar(shift);

                                Console.Write(ch);

                            }

                            else //no overflow
                            {
                                shift = Convert.ToInt32(message[i]) + shift;

                                char ch = Convert.ToChar(shift);

                                Console.Write(ch);
                            }
                        }
                        
                        else if(shift<0)//negative shift
                        {
                            if (ascii + shift > 64)// no overflow 
                            {
                                shift = ascii + shift;

                                char ch = Convert.ToChar(shift);

                                Console.Write(ch);
                            }
                            else //overflow (negative side)
                            {
                                overflow = 65 - (ascii + shift);

                                while(overflow>26)
                                {
                                    overflow = overflow%26;
                                }

                                shift = 91 - overflow;

                                char ch = Convert.ToChar(shift);

                                Console.Write(ch);
                            }

                        }
                        else//no shift
                        {
                            Console.WriteLine(message);

                            break;
                        }
                        
                    }
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

