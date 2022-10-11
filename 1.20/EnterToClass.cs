using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Классы с методами из 16 задания

namespace _1._20
{
    public static class EnterToClass

    {

        //1
        public static int ReadFromConsole()
        {
            Console.WriteLine("Введите число");
            string s = Console.ReadLine();
            int number = Convert.ToInt32(s);
            return number;
        }

        public static int MinusAndDivision(int a, int b, int c)
        {
            int result = (c - b) / a;
            return result;
        }

        public static void WriteResult(int result)
        {
            Console.WriteLine($"Решение уравнения {result}");
        }

        //2

        public static int PlusOrMultiplicationOrMinus(int a, int b)
        {
            int resultPlus = a + b;
            int resultMultiplication = a * b;
            int resultMinus = a - b;
            if (a > b)
            {
                return resultPlus;

            }
            else if (a < b)
            {
                return resultMinus;
            }
            else
            {
                return resultMultiplication;
            }

        }

        //3

        public static string ConvertingTwodigitNumberToString(int number)
        {
            if (number >= 10 && number <= 99)
            {
                int a = number / 10;
                int b = number % 10;
                string x = "";
                string y = "";
                if (number >= 10 && number <= 19)
                {
                    switch (number)
                    {
                        case 10:
                            x ="Десять";
                            break;
                        case 11:
                            x ="Одиннадцать";
                            break;
                        case 12:
                            x ="Двенадцать";
                            break;
                        case 13:
                            x = "Тринадцать";
                            break;
                        case 14:
                            x = "Четырнадцать";
                            break;
                        case 15:
                            x = "Пятнадцать";
                            break;
                        case 16:
                            x = "Шестнадцать";
                            break;
                        case 17:
                            x = "Семнадцать";
                            break;
                        case 18:
                            x = "Восемнадцать";
                            break;
                        case 19:
                            x = "Девятнадцать";
                            break;
                    }
                }
                else
                {
                    switch (a)
                    {
                        case 2:
                            x = "Двадцать";
                            break;
                        case 3:
                            x = "Тридцать";
                            break;
                        case 4:
                            x = "Сорок";
                            break;
                        case 5:
                            x = "Пятьдесят";
                            break;
                        case 6:
                            x = "Шестьдесят";
                            break;
                        case 7:
                            x = "Семдесят";
                            break;
                        case 8:
                            x = "Восемдесят";
                            break;
                        case 9:
                            x = "Девяносто";
                            break;
                    }
                    switch (b)
                    {
                        case 1:
                            y = "один";
                            break;
                        case 2:
                            y = "два";
                            break;
                        case 3:
                            y = "три";
                            break;
                        case 4:
                            y = "четыре";
                            break;
                        case 5:
                            y = "пять";
                            break;
                        case 6:
                            y = "шесть";
                            break;
                        case 7:
                            y = "семь";
                            break;
                        case 8:
                            y = "восемь";
                            break;
                        case 9:
                            y = "девять";
                            break;
                    }

                }
                string result = x + " " + y;
                return result;
            }
            return "";
        }

        //4

        public static bool NumberInRangeFrom0To10OrFrom20To30OFrom40To50(int a)
        {
            if ((a >= 0 && a <= 10) || (a >= 20 && a <= 30) || (a >= 40 && a <= 50))
            {
                bool result;
                return result = true;
            }
            else
            {
                return false;
            }
        }

        //5

        public static int SumOfTheNumbersInsideAAndBThatAreDivisibleBySeven(int a, int b)
        {
            int result = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    result = result + i;
                }

            }
            return result;
        }

        //6

        public static int ReturnsNumberFromFibonacciSeries(int number)
        {
            {
                int a = 0;
                int b = 1;
                int c = a + b;
                int step = 3;
                if (number >= 3)
                {
                    while (step != number)
                    {
                        int d = b;
                        b = c;
                        c = c + d;
                        step = step + 1;
                    }
                }
                else if (number == 2)
                {
                    c = 1;
                }
                else if (number == 1)
                {
                    c = 0;
                }

                int result = c;
                return result;
            }
        }

        //7

        public static int CountOddDigitsAreTheNumbers(int number)
        {
            int s = 0;
            int tmp = 1;
            while (number != 0)
            {
                tmp = number % 10;
                if (tmp % 2 != 0)
                {
                    s = s + 1;
                }
                number = number / 10;
            }
            int result = s;
            return result;
        }


        //8

        public static int MirroringEnteredNumber(int number)
        {
            int tmp = 0;
            string result = "";
            bool isPositiv = number >=0;

            if (!isPositiv)
            {
                number = -number;
            }
            while (number != 0)
            {
                tmp = number % 10;
                result = result + tmp;
                number /= 10;
            }
            if (!isPositiv)
            {
                return -Convert.ToInt32(result);
            }

            return Convert.ToInt32(result);
        }

        //9

        public static bool IdenticalDigitsInTwoNumbers(int a, int b)
        {
            int tmpa = -1;
            int tmpb = -2;
            int bb = 0;
            if (a > 0)
            {
                a = -a;
            }
            if (b > 0)
            {
                b = -b;
            }

            while (tmpa != tmpb && a != 0)
            {
                tmpa = a % 10;
                a /= 10;
                bb = b;

                while (tmpa != tmpb && bb != 0)
                {
                    tmpb = bb % 10;
                    bb /= 10;
                }


            }
            if (tmpa == tmpb)
            {
                return true;
            }
            else
            {
                return false;
            }

        }







    }
}