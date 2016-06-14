#include <iostream>
#include <fstream>
#include <queue>
#include <cmath>

using namespace std;

struct Vector {
	double x;
	double y;
};


int main() {
	queue<vector> q0, q1, q2;
	int count = 0;
	
	ifstream f;
	f.open("d:\\303\\data.txt");	// открыть файл
	vector value;
	// Заполнение конвейера ввода
	while(! f.eof()) {				// пока не конец файла
		f >> v.x;
		f >> v.y;// прочитать значение
		q0.push(value);
		count++;
	}
	f.close();						// закрыть файл

	#pragma omp parallel sections shared(q0, q1, q2, count)
	{
	#pragma omp section	// +
		{
			int processed = 0;
			double value, result;
			while (!q0.empty()) {
				value = q0.front();
				q0.pop();
				cout << "+: < " << value << endl;
				result = (value + 1);	// обработка
				processed++;
				#pragma omp critical (Q1)
					q1.push(result);
				cout << "+: > " << result  << endl;
			}
		}
	#pragma omp section	// -
		{
			int processed = 0;
			bool empty;
			double value, result;
			while (processed < count) {
				while(true) {
					#pragma omp critical (Q1)
					empty = q1.empty();
					if (!empty) break;
				}

				#pragma omp critical (Q1)
				{
					value = q1.front();
					q1.pop();
				}
				cout << "-: < " << value << endl;
				result = (value - 1);	// обработка
				processed ++;
				q2.push(result);
				cout << "-: > " << result << endl;
			}
			#pragma omp section	// -
		{
			int processed = 0;
			bool empty;
			double value, result;
			while (processed < count) {
				while(true) {
					#pragma omp critical (Q1)
					empty = q1.empty();
					if (!empty) break;
				}

				#pragma omp critical (Q1)
				{
					value = q1.front();
					q1.pop();
				}
				cout << "-: < " << value << endl;
				result = (value - 1);	// обработка
				processed ++;
				q2.push(result);
				cout << "-: > " << result << endl;
			}
		}
	}

	// Вывод конвейера q0
	while (!q2.empty()) {
		value = q2.front();
		q2.pop();
		cout << "OUT: " <<  value << endl;
	}

}