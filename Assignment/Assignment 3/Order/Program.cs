﻿using System;

namespace Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num1 + " " + num2 + " " + num3);
                }
                else
                {
                    Console.WriteLine(num1 + " " + num3 + " " + num2);
                }
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num2 + " " + num1 + " " + num3);
                }
                else
                {
                    Console.WriteLine(num2 + " " + num3 + " " + num2);
                }
            }
            else
            {
                if (num1 > num2)
                {
                    Console.WriteLine(num3 + " " + num1 + " " + num2);
                }
                else
                {
                    Console.WriteLine(num3 + " " + num2 + " " + num1);
                }
            }
        }
    }
}
