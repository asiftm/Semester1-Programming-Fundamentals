using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Exam
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
                    case "A1":

                        break;
                    case "B1":
                        string input2 = Console.ReadLine();
                        StreamReader streamReader2 = new StreamReader(input2);
                        string output2 = Question2(input2);
                        Console.WriteLine(output2);
                        break;
                    case "C1":
                        string input3 = Console.ReadLine();
                        StreamReader streamReader3 = new StreamReader(input3);
                        string category = "\t" + Console.ReadLine();
                        int output3 = Question3(input3, category);
                        Console.WriteLine(output3);

                        break;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Crazy Input");
            }
        }


        static string Question2(string input)
        {
            StreamReader streamReader = File.OpenText(input);
            string text = streamReader.ReadLine();

            int charSum = 0;
            int previousCharSum = 100000;
            string output = string.Empty;

            while (text != null)
            {
                string[] array = text.Split(";");
                string email = array[0];
                string name = array[1].Trim();
                string[] emailArray = email.Split("@");
                string nickname = emailArray[0];
                for (int i = 0; i < nickname.Length; i++)
                {
                    char ch = nickname[i];
                    charSum += ch;
                }
                if (charSum < previousCharSum)
                {
                    output = name;
                    previousCharSum = charSum;

                }
                charSum = 0;
                text = streamReader.ReadLine();
            }
            return (output);
        }

        static int Question3(string input, string category)
        {

            StreamReader streamreader = new StreamReader(input);
            string text = streamreader.ReadLine();
            string output = string. Empty;
            while (text != null)
            {
                if (text.Contains(category))
                {
                    string russianword = string.Empty;
                    foreach (var c in text)
                    {
                        if (c > 150)
                        {
                            russianword += c;

                        }
                    }
                    output = output + " " + russianword;
                }
                text = streamreader.ReadLine();
            }
            output = output.Replace(" ", "");
            int length = output.Length;
            return (length);
        }
    }
}
