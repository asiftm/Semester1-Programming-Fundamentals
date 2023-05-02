using System;
using System.IO;
using System.Text.RegularExpressions;

namespace trial_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string question = Console.ReadLine();

                switch (question)
                {
                    case "trial1":
                        string input1 = Console.ReadLine().ToUpper();
                        string output1 = Trial1(input1);
                        Console.WriteLine(output1);
                        break;

                    case "trial2":
                        int input2 = Convert.ToInt32(Console.ReadLine().ToUpper());
                        string output2 = Trial2(input2);
                        Console.WriteLine(output2);
                        break;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("crazy input");
            }
            
        }

        static string Trial1 (string input)
        {
            try
            {
                StreamReader read = File.OpenText("names.txt");
                string text = read.ReadToEnd();
                read.Close();

                Regex pattern = new Regex("[A-Z]{1,}");
                MatchCollection matches = pattern.Matches(text);

                string names = string.Empty;
                foreach (var item in matches)
                {
                    string name = item.ToString();
                    bool condition = false;

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (name.Contains(input[i]))
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
                        names = names + " " + name;
                    }

                }
                names = names.Trim();

                if(names.Length==0)
                {
                    return ("not found");
                }

                string[] namesArray = names.Split(" ");
                Array.Sort(namesArray);

                names = string.Empty;
                for (int i = 0; i < namesArray.Length; i++)
                {
                    names = names + " " + namesArray[i];
                }

                names = names.Trim();

                return (names);
            }
            catch(Exception)
            {
                return ("crazy input");
            }
            
        }

        static string Trial2 (int input)
        {
            if(input < 0)
            {
                return ("crazy input");
            }

            for (int i = input+1; i > input ; i++)
            {
                string numberForward = Convert.ToString(i);

                string numberBackward = string.Empty;

                for (int j = numberForward.Length - 1; j >= 0; j--)
                {
                    numberBackward = numberBackward + numberForward[j];
                }
                numberBackward = numberBackward.Trim();

                if (numberForward == numberBackward)
                {
                    return(numberForward);
                }
            }
            return ("");

        }
    }
}
