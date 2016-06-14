using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public static class Program
    {

        static void Main(string[] args)
        {
            int a;
            string m;
            Console.WriteLine("Введите a (a<10000):");
            a = int.Parse(Console.ReadLine());
            m = Func(a);
            Console.WriteLine("{0}", m);
        }

        public static string Func(int a)
        {
            a = Math.Abs(a);
            string m="";
            int pr = a % 100 / 10, i = 0;
            if (a == 0) m = "ноль";
            while(true)
            {
                if (i == 3)
                {
                    switch (a % 10)
                    {
                        case 1:
                            m = "одна тысяча " + m;
                            break;
                        case 2:
                            m = "две тысячи " + m;
                            break;
                        case 3:
                            m = "три тысячи " + m;
                            break;
                        case 4:
                            m = "четыре тысячи " + m;
                            break;
                        case 5:
                            m = "пять тысяч " + m;
                            break;
                        case 6:
                            m = "шесть тысяч " + m;
                            break;
                        case 7:
                            m = "семь тысяч " + m;
                            break;
                        case 8:
                            m = "восемь тысяч " + m;
                            break;
                        case 9:
                            m = "девять тысяч " + m;
                            break;
                    }
                    i++;
                }
                else
                if (i == 2)
                {
                    switch (a % 10)
                    {
                        case 1:
                            m = "сто " + m;
                            break;
                        case 2:
                            m = "двести " + m;
                            break;
                        case 3:
                            m = "триста " + m;
                            break;
                        case 4:
                            m = "четыреста " + m;
                            break;
                        case 5:
                            m = "пятьсот " + m;
                            break;
                        case 6:
                            m = "шестьсот " + m;
                            break;
                        case 7:
                            m = "семьсот " + m;
                            break;
                        case 8:
                            m = "восемьсот " + m;
                            break;
                        case 9:
                            m = "девятьсот " + m;
                            break;
                    }
                    i++;
                }
                else
                if (i == 1)
                {
                    switch (a % 10)
                    {
                        case 2:
                            m = "двадцать "+m;
                            break;
                        case 3:
                            m = "тридцать "+m;
                            break;
                        case 4:
                            m = "сорок "+m;
                            break;
                        case 5:
                            m = "пятьдесят "+m;
                            break;
                        case 6:
                            m = "шестьдесят "+m;
                            break;
                        case 7:
                            m = "семьдесят "+m;
                            break;
                        case 8:
                            m = "восемьдесят "+m;
                            break;
                        case 9:
                            m = "девяносто "+m;
                            break;
                    }
                    i++;
                }
                else
                if (i == 0)
                {
                    if (pr == 1)
                    {
                        switch (a % 100)
                        {
                            case 10:
                                m = "десять";
                                break;
                            case 11:
                                m = "одиннадцать";
                                break;
                            case 12:
                                m = "двенадцать";
                                break;
                            case 13:
                                m = "тринадцать";
                                break;
                            case 14:
                                m = "четырнадцать";
                                break;
                            case 15:
                                m = "пятнадцать";
                                break;
                            case 16:
                                m = "шестнадцать";
                                break;
                            case 17:
                                m = "семнадцать";
                                break;
                            case 18:
                                m = "восемнадцать";
                                break;
                            case 19:
                                m = "девятнацать";
                                break;
                        }
                        i += 2;
                        a = a / 10;
                    }
                    else
                    {
                        switch (a % 10)
                        {
                           case 1:
                                m = "один";
                                break;
                            case 2:
                                m = "два";
                                break;
                            case 3:
                                m += "три";
                                break;
                            case 4:
                                m = "четыре";
                                break;
                            case 5:
                                m = "пять";
                                break;
                            case 6:
                                m = "шесть";
                                break;
                            case 7:
                                m = "семь";
                                break;
                            case 8:
                                m = "восемь";
                                break;
                            case 9:
                                m = "девять";
                                break;
                        }
                        i++;
                    }
                }

                a = a / 10;
                if (a == 0) break;
            }
            return m;

            }

        }
    }

