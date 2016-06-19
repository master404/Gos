using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISequence
{
    interface ISequence
    {
        double GetElement(int number);
    }

    class ArithmeticProgression : ISequence
    {
        public double origin;
        public double dif;
        public ArithmeticProgression(double a, double d)
        { 
            origin = a;
            dif = d;
        }
        public double GetElement(int number)
        {
            if (number < 0) return 0;
            double num = origin;
            for (int i = 1; i < number; i++) num += dif;
            return num;
        }

        public double Sum(int number)
        {
            if (number < 0) return 0;
            double sum = origin;
            double num = origin;
            for (int i = 1; i < number; i++)
            {
                num += dif;
                sum += num;
            }
            return sum;
        }
    }

    class GeometricProgression : ISequence
    {
        public double origin;
        public double dif;
        public GeometricProgression(double a, double d)
        {
            origin = a;
            dif = d;
        }
        public double GetElement(int number)
        {
            if (number < 0) return 0;
            double num = origin;
            for (int i = 1; i < number; i++) num *= dif;
            return num;
        }
        public double Sum(int number)
        {
            if (number < 0) return 0;
            double sum = origin;
            double num = origin;
            for (int i = 1; i < number; i++)
            {
                num *= dif;
                sum += num;
            }
            return sum;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression ap = new ArithmeticProgression(3,5);
            Console.WriteLine(ap.Sum(5));

            GeometricProgression gp = new GeometricProgression(1, 2);
            Console.WriteLine(gp.Sum(5));
        }
    }
}
