using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace _2nd_LR
{
    public class Tasks
    {
        //Task №1:
        public void GettingCurrentTimeAndDate()
        {
            DateTime CurrentDate = DateTime.Now;
            string Date1 = CurrentDate.ToString("dd MMMM yyyy hh:mm tt");
            string Date2 = CurrentDate.ToString("R");
            string Date3 = CurrentDate.ToString("O");
            char i;

            Console.WriteLine(Date1);
            for (i = '0'; i <= '9'; i++)
                Console.WriteLine("Amount of " + i + ": " + AmountOfSymbols(Date1, i));

            Console.WriteLine("\n" + Date2);
            for (i = '0'; i <= '9'; i++)
                Console.WriteLine("Amount of " + i + ": " + AmountOfSymbols(Date2, i));

            Console.WriteLine("\n" + Date3);
            for (i = '0'; i <= '9'; i++)
                Console.WriteLine("Amount of " + i + ": " + AmountOfSymbols(Date3, i));
        }

        private int AmountOfSymbols(string Date, char symbol)
        {
            int amount = 0, i;

            for (i = 0; i < Date.Length; i++)
            {
                if (Date[i] == symbol)
                    amount++;
            }
            return amount;
        }



        //Task №4
        public void CalculationOfTheDegree(int a, int b)
        {
            BigInteger number;
            for (number = 1; a <= b; a++)
            {

                number *=a;

            }
            Console.Write("Your number = {0}\n", number);
            int degree = 0;
            BigInteger del;
            while(true)
            {

                del = number % 2;
                number /= 2;
                if (del == 0)
                {
                    degree++;
                }
                else break;

            }
            Console.Write("The highest degree of 2 = {0} \n\n", degree);
        }



        //task №5
        public char[] FindNotEnglishUpperLetters(string str)
        {
            char[] input = str.ToCharArray();
            List<char> result = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                    if (!(input[i] >= 'A' && input[i] <= 'Z'))
                    {
                        result.Add(input[i]);
                        result.Add(' ');
                    }
            }
            char[] Result = result.ToArray();
            return Result;
        }
    }
}
