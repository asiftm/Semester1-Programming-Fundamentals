using System;

namespace Monster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int method = Convert.ToInt32(Console.ReadLine());

                switch (method)
                {
                    case 1:
                        int inputOne = Convert.ToInt32(Console.ReadLine());
                        int outputOne = NextLeapYear(inputOne);
                        Console.WriteLine(outputOne);
                        break;

                    case 2:
                        int inputTwo = Convert.ToInt32(Console.ReadLine());
                        int outputTwo = SumOfDigits(inputTwo);
                        Console.WriteLine(outputTwo);
                        break;

                    case 3:
                        int inputThree = Convert.ToInt32(Console.ReadLine());
                        bool outputThree = IsFibonacci(inputThree);
                        Console.WriteLine(outputThree);
                        break;

                    case 4:
                        int inputFour = Convert.ToInt32(Console.ReadLine());
                        int outputFour = NextPrime(inputFour);
                        Console.WriteLine(outputFour);
                        break;

                    case 5:
                        string inputFive = Console.ReadLine();
                        string outputFive = ReverseCase(inputFive);
                        Console.WriteLine(outputFive);
                        break;

                    case 6:
                        string inputSix = Console.ReadLine();
                        bool outputSix = Palindrome(inputSix);
                        Console.WriteLine(outputSix);
                        break;

                    case 7:
                        string[] inputSeven = Console.ReadLine().Split(",");
                        string text1 = inputSeven[0].ToLower();
                        string text2 = inputSeven[1].ToLower();
                        bool outputSeven = Anagram(text1, text2);
                        Console.WriteLine(outputSeven);
                        break;

                    case 8:
                        string inputEight = Console.ReadLine();
                        int outputEight = AlphabetSum(inputEight.ToLower());
                        Console.WriteLine(outputEight);
                        break;

                    case 9:
                        string[] inputNine = Console.ReadLine().Split(",");
                        int num1 = int.Parse(inputNine[0]);
                        int num2 = int.Parse(inputNine[1]);
                        int lowestCommonMultiplier = LCM(num1, num2);
                        Console.WriteLine(lowestCommonMultiplier);
                        break;

                    case 10:
                        string[] inputTen = Console.ReadLine().Split(",");
                        int a = int.Parse(inputTen[0]);
                        int b = int.Parse(inputTen[1]);
                        int outputTen = GCD(a, b);
                        Console.WriteLine(outputTen);
                        break;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("crazy input");
            }
        }

        static int NextLeapYear(int year)
        {
            int output = 0;
            for (int i = year + 1; i > year; i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                        {
                            output = i;
                            break;
                        }
                    }
                    else
                    {
                        output = i;
                        break;
                    }
                }
            }
            return(output);
        }
        static int SumOfDigits(int nr)
        {
            string digits = nr.ToString();
            int add = 0;

            while (digits.Length != 1)
            {
                add = 0;
                for (int j = 0; j < digits.Length; j++)
                {
                    add = add + int.Parse(digits[j].ToString());
                }
                digits = add.ToString();
            }
            return (add);
        }
        static bool IsFibonacci(int number)
        {
            bool condition = false;
            int firstNumber = 1;
            int secondNumber = 1;
            int temp = (firstNumber + secondNumber);

            if (number == firstNumber || number == temp)
            {
                condition = true;
                return (condition);
            }

            while (temp <= number)
            {
                firstNumber = secondNumber;

                secondNumber = temp;

                temp = firstNumber + secondNumber;

                if(temp==number)
                {
                    condition = true;
                    return (condition);
                }
            }
            return (condition);
        }
        static int NextPrime(int number)
        {
            int output = 0;

            for (int i = number + 1; i > number; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime == true)
                {
                    output = i;
                    break;
                }
            }
            return(output);
        }
        static string ReverseCase(string text)
        {
            string output = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                char alphabet = text[i];
                if (alphabet > 64 && alphabet < 91)
                {
                    string lower = alphabet.ToString();
                    output += lower.ToLower();
                }
                else if (alphabet > 96 && alphabet < 122)
                {
                    string upper = alphabet.ToString();
                    output += upper.ToUpper();
                }
                else
                {
                    output += text[i];
                }
            }
            return (output);
        }
        static bool Palindrome(string text)
        {
            text = text.ToLower().Replace(" ", "");
            bool palindrome = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == text[text.Length - 1 - i])
                {
                    palindrome = true;
                }
                else
                {
                    palindrome = false;
                    return (palindrome);
                }
            }
            return (palindrome);
        }
        static bool Anagram(string text1, string text2)
        {
            bool condition = false;

            for (int i = 0; i < text1.Length; i++)
            {
                if (text1[i] > 96 && text1[i] < 123)
                {
                    if (!text2.Contains(text1[i]))
                    {
                        condition = false;
                        return (condition);
                    }
                    else
                    {
                        condition = true;
                    }
                }
                else
                {
                    condition = true;
                }
            }
            return (condition);
        }
        static int AlphabetSum(string text)
        {
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > 96 && text[i] < 123)
                {
                    int ascii = Convert.ToChar(text[i]) - 96;
                    sum += ascii;
                }
            }
            return (sum);
        }
        static int LCM(int a, int b)
        {
            int lowestCommonMultiplier = a * b;
            return (lowestCommonMultiplier);
        }
        static int GCD(int a, int b)
        {
            string div1 = string.Empty;
            string div2 = string.Empty;

            for (int i = a; i > 0; i--)
            {
                int reminder = a % i;

                if (reminder == 0)
                {
                    div1 = div1 + " " + a / i;
                }
            }

            for (int i = b; i > 0; i--)
            {
                int reminder = b % i;

                if (reminder == 0)
                {
                    div2 = div2 + " " + b / i;
                }
            }

            div1 = div1.Trim();
            div2 = div2.Trim();

            string[] divArray1 = div1.Split(" ");
            string[] divArray2 = div2.Split(" ");

            string store = string.Empty;
            for (int i = 0; i < divArray1.Length; i++)
            {
                for (int j = 0; j < divArray2.Length; j++)
                {
                    string aa = divArray2[j];
                    if (divArray1[i] == aa && !store.Contains(divArray1[i]))
                    {
                        store = store + divArray1[i] + " ";
                        break;
                    }
                }
            }

            int temp = 0;
            int output = 0;
            int number = 0;

            for (int i = 0; i < store.Length; i++)
            {
                if (store[i] != ' ')
                {
                    number = int.Parse(store[i].ToString());
                    if (number > temp)
                    {
                        output = number;
                    }
                    temp = number;
                }
            }
            return(number);

        }
    }
}
