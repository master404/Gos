#include "stdafx.h"
#include <iostream>
#include <math.h>
#include <omp.h>

using namespace std;
double Pow(int n, int s)
{
	if (n < 0) return -1;
	double m = 1;
	for(int i=0; i<s; i++)
	{
		m *=n; 
	}
	return n;
};
int _tmain(int argc, _TCHAR* argv[])
{
	setlocale(LC_ALL, "Russian");
	int n = 111; //проверяемое число
	int k = 100; //число проверок
	bool flag = true;
	double start_time1 = omp_get_wtime();
	for(int i=0; i<k; i++)
	{
		int c = 2+rand()%18;
		if((c%n!=0)&&(n%c!=0))
		{
			//cout<<Pow(i,n-1)<<"\n";
			//cout<<"Делимое: "<<i<<" Остаток: "<<fmod(Pow(i,n-1),n)<<"\n";
			if(!(fmod(Pow(c,n-1),n)==1)) flag = false;
		}
	}
	double end_time1 = omp_get_wtime();
	cout<<"Время выполнения в одном потоке: "<<end_time1-start_time1<<"ms\n";
	
	double start_time2 = omp_get_wtime();
	#pragma omp parallel for
	for(int i=0; i<k; i++)
	{
		int c = 2+rand()%18;
		if((c%n!=0)&&(n%c!=0))
		{
			//cout<<Pow(i,n-1)<<"\n";
			//cout<<"Делимое: "<<i<<" Остаток: "<<fmod(Pow(i,n-1),n)<<"\n";
			if(!(fmod(Pow(c,n-1),n)==1)) flag = false;
		}
	}
	double end_time2 = omp_get_wtime();
	cout<<"Время выполнения в нескольких потоках: "<<end_time2-start_time2<<"ms\n";
	
	if(flag)
	{
		cout<<"Можно утверждать, что число простое\n";
	}
	else
	{
		cout<<"Число составное\n";
	}
	return 0;
}

