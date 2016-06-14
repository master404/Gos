#include <iostream>
#include <cstdlib>
#include <omp.h>
using namespace std;

int main() {
	setlocale(LC_ALL,"");
	int N=10,K=5;
	double *a, *b,*c;
	c = new double[K];
	cout<<"Для 1 потока:"<<endl;
	for (int j = 0; j < K; j++) 
	{
	a = new double[N];
	b = new double[N];
	
	for (int i = 0; i < N; i++) {
		a[i] = rand() % 10;
		b[i] = rand() % 10;
	}
	double start = omp_get_wtime();
	volatile double s = 0;
	for (int i = 0; i < N; i++)
		s += a[i] * b[i];
	double stop = omp_get_wtime();
	c[j]=(stop - start) * 1000; 
	cout << j+1<< ") Для N = " << N << " s = " << s <<  " t = " << (stop - start) * 1000 << " ms" << endl;
	N=N*10;
	}
	N=10;
	cout<<"Для 2х потоков:"<<endl;
	for (int j = 0; j < ; j++) 
	{a = new double[N];
	b = new double[N];
	for (int i = 0; i < N; i++) {
		a[i] = rand() % 10;
		b[i] = rand() % 10;
	}
	double start = omp_get_wtime();
	volatile double s = 0;
	#pragma omp parallel for reduction(+:s)
	for (int i = 0; i < N; i++)
		s += a[i] * b[i];
	double stop = omp_get_wtime();
	cout << j+1<< ") Для N = " << N << " s = " << s <<  " t = " << (stop - start) * 1000 << " ms"
	if (c[j]-(stop - start) * 1000>0)
	cout<<" (+"<<c[j]-(stop - start) * 1000<<" ms)"<< endl;
	else
	cout<<" ("<<c[j]-(stop - start) * 1000<<" ms)"<< endl;
	N=N*10;
	}
	delete[] a;
	delete[] b;
}