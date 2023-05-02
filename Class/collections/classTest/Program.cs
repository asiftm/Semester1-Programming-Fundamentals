using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace classTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("new student? Y/N");
            string answer = Console.ReadLine().ToLower();

            List<string> studentName = new List<string>();
            List<double> classPoint = new List<double>();
            List<double> examPoint = new List<double>();

            while(answer == "y")
            {
                Console.WriteLine("what is your name?");
                string name = Console.ReadLine();
                studentName.Add(name);

                Console.WriteLine("what is your class point?");
                double point1 = Convert.ToInt32(Console.ReadLine());
                classPoint.Add(point1);

                Console.WriteLine("what is your exam point?");
                double point2 = Convert.ToInt32(Console.ReadLine());
                examPoint.Add(point2);

                Console.WriteLine("new student? Y/N");
                answer = Console.ReadLine().ToLower();
            }
            List<double> total = new List<double>();

            for( int i=0;i< studentName.Count;i++)
            {
                double totalScore = ((0.3 * classPoint[i]) + (0.7 * examPoint[i]));
                if(totalScore>7 && totalScore<14)
                {
                    if (examPoint[i] < 6)
                    {
                        total.Add(7);
                    }
                    else if (classPoint[i] < 6)
                    {
                        total.Add(7);
                    }
                    else
                    {
                        total.Add(totalScore);
                    }
                }
                else
                {
                    total.Add(totalScore);
                }
                Console.WriteLine($"Total point of \"{studentName[i]}\" is : {total[i]}");
            }

            Console.WriteLine($"average point : {total.Average()}");
        }
    }
}














