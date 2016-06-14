#include <windows.h>
#include <glut.h>   //Подключение библиотеки glut.h
#undef UNICODE
#include <glaux.h>

void CALLBACK resize(int width, int height);
void CALLBACK display(void);
void CALLBACK mouse_leftbtn(AUX_EVENTREC* event);
void CALLBACK mouse_rightbtn(AUX_EVENTREC* event);
void CALLBACK key_up();
void CALLBACK key_down();
void CALLBACK key_space();
int on_off = 0;
double speed = 0.2;
int os=2;
void main()
{
	auxInitDisplayMode(AUX_RGBA | AUX_DEPTH | AUX_DOUBLE);
	auxInitPosition(50, 10, 400, 400);
	auxInitWindow(" Куб");
	auxReshapeFunc(resize);
	glEnable(GL_ALPHA_TEST);
	glEnable(GL_DEPTH_TEST);
	glEnable(GL_COLOR_MATERIAL);
	glEnable(GL_BLEND);
	glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
	glEnable(GL_LIGHTING);
	glEnable(GL_LIGHT0);
	float pos[4] = { 0, 5, 5, 1 };
	float dir[3] = { 0, -1, -1 };
	glLightfv(GL_LIGHT0, GL_POSITION, pos);
	glLightfv(GL_LIGHT0, GL_SPOT_DIRECTION, dir);
	auxMouseFunc(AUX_LEFTBUTTON, AUX_MOUSEDOWN, mouse_leftbtn);
	auxKeyFunc(AUX_UP,key_up);
	auxKeyFunc(AUX_DOWN, key_down);
	auxKeyFunc(AUX_SPACE, key_space);
	auxIdleFunc(display);
	auxMainLoop(display);
}
void CALLBACK resize(int width, int height)
{
	glViewport(0, 0, width, height);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	glOrtho(-5, 5, -5, 5, 2, 12);
	gluLookAt(3, 0, 5, 0, 0, 0, 0, 1, 0);
	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();
}
static float angle = 0;
void CALLBACK display(void)
{
	// Очистка буфера кадра
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	
	glColor3f(0, 1, 0);
	switch (os)
	{
	case 0: glRotatef(angle, 1, 0, 0); break;
	case 1: glRotatef(angle, 0, 0, 1); break;
	default: glRotatef(angle, 0, 1, 0); break;
	}
	glPushMatrix();
	glutSolidCube(3);
	glPopMatrix();
	if (on_off == 1)
	{
		angle = speed;
	}
	else{ angle = 0; }
	// Копирование содержимого буфера кадра на экран
	glFlush();
	auxSwapBuffers();
}
void CALLBACK mouse_leftbtn(AUX_EVENTREC* event)
{
	if (++on_off == 2)
		on_off = 0;
}
void CALLBACK key_up()
{
	speed = speed + 0.1;
	
}
void CALLBACK key_down()
{
	speed=speed - 0.1;
}
void CALLBACK key_space()
{
	if (++os == 3)
		os = 0;
}

