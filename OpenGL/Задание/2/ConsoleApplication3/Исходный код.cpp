#include <windows.h>
#include <glut.h>   //Подключение библиотеки glut.h
#undef UNICODE
#include <glaux.h>
#include<math.h>

void drawOneLine(double x1, double y1, double x2, double y2);
void CALLBACK resize(int width, int height);
void CALLBACK display();
void main()
{
	auxInitDisplayMode(AUX_SINGLE | AUX_RGBA);
	auxInitPosition(0, 0, 400, 150);
	auxInitWindow("Синус");
	auxReshapeFunc(resize);
	glClearColor(0.0, 0.0, 0.0, 0.0);
	glShadeModel(GL_FLAT);
	auxMainLoop(display);
}
void drawOneLine(double x1, double y1, double x2, double y2)
{
	glBegin(GL_LINES);
	glVertex2d(x1, y1);
	glVertex2d(x2, y2);
	glEnd();
}

void CALLBACK resize(int width, int height)
{
	glViewport(0, 0, width, height);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluPerspective(100.0, (double)width / (double)height, 1.0, 20.0);
	gluLookAt(0, 0, 5, 0, 0, 0, 0, 1, 0);
}
void CALLBACK display()
{
	glClear(GL_COLOR_BUFFER_BIT);
	glColor3d(1.0, 1.0, 1.0); // Все отрезки рисуются белым цветом
	glBegin(GL_LINES);
	for (double i = -7; i < 7;i+=0.000001)
	glVertex2d(i,5*cos(i*i));
	glEnd();
	glColor3d(0, 1.0, 0);
	drawOneLine(0, -7,0,7);
	drawOneLine(-7, 0, 7, 0);
	for (int i = -7; i < 7; i++)
	{
		drawOneLine(i, -0.3, i, 0.3);
		drawOneLine(-0.3, i, 0.3, i);
	}
	glFlush();
}