/*
Escribir una funci�n que lea un n�mero entero y un n�mero real por teclado, en funci�n 
del n�mero entero se aplicar� una de las  funciones de conversi�n anteriores,  tal y como 
muestra la siguiente tabla: 

                              Conversi�n                  Entero  
                              Cent�metros a Pulgadas        0  
                              Cent�metros a pies            1 
                              Pulgadas a Cent�metros        2 
                              Pulgadas a Pies               3 
                              Pies a Cent�metros            4 
                              Pies a Pulgadas               5 
*/

#include<iostream>
#include<conio.h>
#include<stdio.h>
#include<windows.h>
#include<math.h>
#include<iomanip>
#include<cstdlib>
#include <string> 

using namespace std;
int a;
float centimetro;
float pulgada;
float pie;
void cm1 (float u);
void ft1 (float v);
void in1 (float w);
void cm2 (float x);
void ft2 (float y);
void in2 (float z);
int main()
{
	cout<<"Seleccione el tipo de conversion que desea realizar (1-6)"<<endl;
	cout<<"1. De centimetros a pulgadas"<<endl;
	cout<<"2. De centimetros a pies"<<endl;
	cout<<"3. De pulgadas a centimetros"<<endl;
	cout<<"4. De pulgadas a pies"<<endl;
	cout<<"5. De pies a centimetros"<<endl;
	cout<<"6. De pies a pulgadas"<<endl;
	cin>>a;
	switch (a)
	{
		case 1:
		    cm1(pulgada);
		    break;
	    case 2:
		    cm2(pie);
		    break;
		case 3:
		    in1(centimetro);
		    break;
		case 4:
		    in2(pulgada);
		    break;
	    case 5:
		    ft1(centimetro);
		    break;
		case 6:
		    ft2(pie);
		    break;
	}
    getch();
return 0;
}
void cm1 (float u)
{
	cout<<"Seleccione la cantidad en centimetros que desea convertir"<<endl;
	cin>>u;
	pulgada = u/2.54;
	cout<<"La conversion es "<<pulgada<<endl;
}
void cm2 (float v)
{
	cout<<"Seleccione la cantidad en centimetros que desea convertir"<<endl;
	cin>>v;
	pie = v/30.48;
	cout<<"La conversion es "<<pie<<endl;
}
void in1 (float y)
{
	cout<<"Seleccione la cantidad en pulgadas que desea convertir"<<endl;
	cin>>y;
	centimetro = y*2.54;
	cout<<"La conversion es "<<centimetro<<endl;
}
void in2 (float z)
{
	cout<<"Seleccione la cantidad en pulgadas que desea convertir"<<endl;
	cin>>z;
	pie = z/12;
	cout<<"La conversion es "<<pulgada<<endl;
}
void ft1 (float w)
{
	cout<<"Seleccione la cantidad en pies que desea convertir"<<endl;
	cin>>w;
	centimetro = w * 30/48;
	cout<<"La conversion es "<<centimetro<<endl;
}
void ft2 (float x)
{
	cout<<"Seleccione la cantidad en pies que desea convertir"<<endl;
	cin>>x;
	pie = x*12;
	cout<<"La conversion es "<<pie<<endl;
}

