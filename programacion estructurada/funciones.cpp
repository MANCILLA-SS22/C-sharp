#include<iostream>
#include<conio.h>
#include<stdio.h>
#include<windows.h>
#include<math.h>
#include<iomanip>
#include<cstdlib>
#include <string> 

using namespace std;
void hipotenuse1(double x);
void hipotenuse2(double y);
void hipotenuse3(double z);
void proceso();
double x;
double y;
double z;
double triangulo1_lado1;
double triangulo1_lado2;
double triangulo2_lado1;
double triangulo2_lado2;
double triangulo3_lado1;
double triangulo3_lado2;

int main()
{
    proceso();
	hipotenuse1(x);
	hipotenuse2(y);
	hipotenuse3(z);
	
    getch();
return 0;
}

void proceso()
{
	triangulo1_lado1 = 3;
    triangulo1_lado2 = 4;
    triangulo2_lado1 = 5;
    triangulo2_lado2 =12;
    triangulo3_lado1 = 8;
    triangulo3_lado2 =15;
	cout<<"El triangulo 1 tiene un lado 1 de "<<triangulo1_lado1<<" y un lado 2 de "<<triangulo1_lado2<<endl;
	cout<<"El triangulo 2 tiene un lado 1 de "<<triangulo2_lado1<<" y un lado 2 de "<<triangulo2_lado2<<endl;
	cout<<"El triangulo 3 tiene un lado 1 de "<<triangulo3_lado1<<" y un lado 2 de "<<triangulo3_lado2<<endl;
}
void hipotenuse1(double x)
{
	x = sqrt(pow(triangulo1_lado1,2) + pow(triangulo1_lado2,2));
	cout<<"La hipotenusa de x es "<<x<<endl;
}
void hipotenuse2(double y)
{
	y = sqrt(pow(triangulo2_lado1,2) + pow(triangulo2_lado2,2));
	cout<<"La hipotenusa de y es "<<y<<endl;
}
void hipotenuse3(double z)
{
	z = sqrt(pow(triangulo1_lado1,2) + pow(triangulo3_lado2,2));
	cout<<"La hipotenusa de z es "<<z<<endl;
}
