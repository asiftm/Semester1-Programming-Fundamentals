using System;

namespace Find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();

                string[] array = input.Split(",");

                bool condition = false;

                foreach (var item in array)
                {
                    if (item.Contains("0") && item[0] != '0')
                    {
                        string num = item.Replace(" ", "");

                        foreach (var i in num)
                        {
                            if ((i > 47 && i < 58) || i == 46)
                            {
                                condition = true;
                            }
                            else
                            {
                                condition = false;
                                break;
                            }
                        }
                        if (condition == true)
                        {
                            Console.Write(num + " ");
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
