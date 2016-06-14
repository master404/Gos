using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //n - кол-во строк матрицы A, m - кол-во столбцов матрицы A и кол-во строк матрицы B, q - кол-во столбцов матрицы B
            int n = 2, m = 3, q = 4;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            
            //объявление матриц
            double[,] A = new double[n, m];
            double[,] B = new double[m, q];
            double[,] C = new double[n,q];
            
            //заполнение и вывод исходных матриц
            Random rand = new Random();

            Console.WriteLine("Matrix A:");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    A[i, j] = rand.Next(0,20);
                    Console.Write(A[i,j]+" ");
                };
                Console.WriteLine();
            }
            
            Console.WriteLine("\nMatrix B:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    B[i, j] = rand.Next(0, 20);
                    Console.Write(B[i, j] + " ");
                };
                Console.WriteLine();
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    for (int k = 0; k < m; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            };
      
            timer.Stop();

            Console.WriteLine("\nMatrix C:");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < q; j++) {
                    Console.Write(C[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nВремя выполнения:" + timer.ElapsedMilliseconds.ToString() + "ms");

        }
    }
}
