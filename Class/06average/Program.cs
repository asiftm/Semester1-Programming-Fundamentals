using System;
using System.Linq;

namespace _06average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            //int b = 2;
            //int c = 3;
            //int d = 4;
            //int e = 5;
            //int f = 6;
            //int g = 7;
            //int h = 8;
            //int i = 9;
            //int j = 10;

            //int average = (a + b + c + d + e + f + g + h + i + j) / 10;

            //Console.WriteLine(average);


            //int totalStudents = 10;
            //int avg = 0;
            //int score=0;

            //for (int i = 0; i < totalStudents; i++)
            //{
            //    score=Convert.ToInt32(Console.ReadLine());
            //    avg +=score;
            //}
            //avg /= totalStudents;

            //Console.WriteLine(avg);

            //int[] score = { 4, 5, 6, 7, 8, 9, 4, 5, 6, 7 };
            //int sum = 0;

            //for (int i = 0; i < score.Length; i++)
            //{
            //    sum = sum + score[i];
            //}

            //Console.WriteLine(sum / score.Length);






            //string inputScores=Console.ReadLine();
            //string [] stringScores = inputScores.Split("");
            //2 ways of putting input to array,the in the up or the one in the down

            string[] input = (Console.ReadLine()).Split(" ");

            double[] grades = Array.ConvertAll(input, double.Parse);
            double average=0;

            //foreach (double grade in grades)
            //{
            //    average += grade;

            //}
            //average /= grades.Length;
            //or
            average = grades.Sum() / grades.Length;
            //or directly Console.WriteLine(grades.average);



            Console.WriteLine(average);
            
           



        }
    }
}
