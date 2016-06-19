using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Complex_class
{
    public class Complex
    {
        public double im, re;

        //конструктор, принимающий действительную и мнимую часть
        public Complex(double a, double b)
        { 
            im = b;
            re = a;
        }

        //копирующий конструктор
        public Complex(Complex num)
        {
            im = num.im;
            re = num.re;
        }

        //методы Re и Im, возвращающие мнимую и действительную части
        public double Re()
        {
            return re;
        }

        public double Im()
        {
            return im;
        }

        //методы Abs и Arg, возвращающие модуль и аргумент числа
        public double Abs()
        {
            return Math.Sqrt(Math.Pow(re, 2) + Math.Pow(im, 2));
        }

        public double Arg()
        {
            if (re > 0) return Math.Atan(im / re);
            if (re < 0 && im > 0) return Math.PI + Math.Atan(im / re);
            if (re < 0 && im < 0) return -Math.PI + Math.Atan(im / re);
            return 0;
        }

        //операции сложения, вычитания, умножения и деления
        public static Complex operator +(Complex num1, Complex num2)
        {
            return new Complex(num1.re + num2.re, num1.im + num2.im);
        }

        public static Complex operator -(Complex num1, Complex num2)
        {
            return new Complex(num1.re - num2.re, num1.im - num2.im);
        }

        public static Complex operator *(Complex num1, Complex num2)
        {
            return new Complex(num1.re*num2.re-num1.im*num2.im, num1.re * num2.im+num2.re*num1.im);
        }

        public static Complex operator /(Complex num1, Complex num2)
        {
            Complex linked = new Complex(num2.re, -num2.im);
            Complex chislitel = num1 * linked;
            double znamenatel = (num2 * linked).re;
            return new Complex(Math.Round(chislitel.re/znamenatel,3), Math.Round(chislitel.im/znamenatel,3));
        }

        public override string ToString()
        {
            if (re == 0 && im == 0) return "0";
            if (re == 0 && im != 0) return im+"i";
            if (re != 0 && im == 0) return re+"";
            if (im > 0) return "" + re + "+" + im + "i";
            return "" + re + im + "i";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex com1 = new Complex(4, 6);
            Console.WriteLine(com1);
            Complex com2 = new Complex(7, -11);
            Console.WriteLine(com2);
            Console.WriteLine();
            Complex sum = com1 + com2;
            Console.WriteLine("Sum: "+sum);
            Complex dif = com1 - com2;
            Console.WriteLine("Dif: " + dif);
            Complex mul = com1 * com2;
            Console.WriteLine("Mul: " + mul);
            Complex div = com1 / com2;
            Console.WriteLine("Div: " + div);
        }
    }
}
