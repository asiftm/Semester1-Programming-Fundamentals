using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Hits_per_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                StreamReader read = File.OpenText(input);
                string text = read.ReadToEnd();
                read.Close();

                string[] arrayOfAllText = text.Split(";");
                string everyYear = string.Empty;
                string eachYear = string.Empty;

                for (int i = 3; i < arrayOfAllText.Length; i = i + 5)
                {
                    if ((arrayOfAllText[i].ToString() != "nan") && (arrayOfAllText[i].ToString() != "Date"))
                    {
                        string year = arrayOfAllText[i];

                        everyYear = everyYear + arrayOfAllText[i] + " ";

                        if (!eachYear.Contains(year))
                        {
                            eachYear = eachYear + year + " ";
                        }
                    }
                }

                everyYear = everyYear.Trim();
                eachYear = eachYear.Trim();

                int[] everyYearIntArray = Array.ConvertAll(everyYear.Split(" "), int.Parse);
                Array.Sort(everyYearIntArray);

                int[] eachYearIntArray = Array.ConvertAll(eachYear.Split(" "), int.Parse);
                Array.Sort(eachYearIntArray);

                int count = 0;

                for (int i = 0; i < eachYearIntArray.Length; i++)
                {
                    for (int j = 0; j < everyYearIntArray.Length; j++)
                    {
                        if (eachYearIntArray[i] == everyYearIntArray[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{eachYearIntArray[i]}: {count} hit(s)");
                    count = 0;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
            
        }
    }
}


