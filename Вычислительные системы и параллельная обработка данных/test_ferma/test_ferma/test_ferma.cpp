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
	int n = 111; //����������� �����
	int k = 100; //����� ��������
	bool flag = true;
	double start_time1 = omp_get_wtime();
	for(int i=0; i<k; i++)
	{
		int c = 2+rand()%18;
		if((c%n!=0)&&(n%c!=0))
		{
			//cout<<Pow(i,n-1)<<"\n";
			//cout<<"�������: "<<i<<" �������: "<<fmod(Pow(i,n-1),n)<<"\n";
			if(!(fmod(Pow(c,n-1),n)==1)) flag = false;
		}
	}
	double end_time1 = omp_get_wtime();
	cout<<"����� ���������� � ����� ������: "<<end_time1-start_time1<<"ms\n";
	
	double start_time2 = omp_get_wtime();
	#pragma omp parallel for
	for(int i=0; i<k; i++)
	{
		int c = 2+rand()%18;
		if((c%n!=0)&&(n%c!=0))
		{
			//cout<<Pow(i,n-1)<<"\n";
			//cout<<"�������: "<<i<<" �������: "<<fmod(Pow(i,n-1),n)<<"\n";
			if(!(fmod(Pow(c,n-1),n)==1)) flag = false;
		}
	}
	double end_time2 = omp_get_wtime();
	cout<<"����� ���������� � ���������� �������: "<<end_time2-start_time2<<"ms\n";
	
	if(flag)
	{
		cout<<"����� ����������, ��� ����� �������\n";
	}
	else
	{
		cout<<"����� ���������\n";
	}
	return 0;
}

