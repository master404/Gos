#include "stdafx.h"
#include <iostream>
#include <omp.h>

using namespace std;
int _tmain(int argc, _TCHAR* argv[])
{
	setlocale(LC_ALL, "Russian");
	const int n=100; //кол-во строк матрицы A
	const int m=150; //кол-во столбцов матрицы A и кол-во строк матрицы B
	const int q=200; //кол-во столбцов матрицы B
            
    //объ€вление матриц
    double A[n][m];
    double B[m][q];
    double C[n][q];
	double C2[n][q];
            
    //заполнение и вывод исходных матриц
    //cout<<"Matrix A:\n";
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            A[i][j] = rand()%20;
            //cout<<A[i][j]<<" ";
        };
        //cout<<"\n";
    }
            
    //cout<<"\nMatrix B:\n";
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < q; j++)
        {
            B[i][j] = rand()%20;
            //cout<<B[i][j]<<" ";
        };
        //cout<<"\n";
    }

	double start_time1 = omp_get_wtime();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < q; j++)
        {
            C[i][j] = 0;
			for (int k = 0; k < m; k++)
            {
               C[i][j] += A[i][k] * B[k][j];
            }
        }
    };
    double end_time1 = omp_get_wtime();  
    cout<<"\n¬рем€ выполнени€ одним потоком: "<<end_time1-start_time1<<"ms\n";
   // cout<<"\nMatrix C:\n";
    //for (int i = 0; i < n; i++) {
     //   for (int j = 0; j < q; j++) {
     //       cout<<C[i][j]<<" ";
     //   }
     //   cout<<"\n";
    //}

    
	
	//int N = 2; //число потоков
	double start_time2 = omp_get_wtime();
	#pragma omp parallel num_threads(4)
	{
		#pragma omp parallel for 
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < q; j++)
			{
				C2[i][j] = 0;
				for (int k = 0; k < m; k++)
				{
				   C2[i][j] += A[i][k] * B[k][j];
				}
			}
		};
	};
	double end_time2 = omp_get_wtime();
	cout<<"\n¬рем€ выполнени€ несколькими потоками: "<<end_time2-start_time2<<"ms\n";
}

