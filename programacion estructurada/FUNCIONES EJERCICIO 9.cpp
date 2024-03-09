/*
Escriba las funciones necesarias para poder calcular la equivalencia entre centímetros, pies 
y pulgadas. 
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
int x;
float m;
float n;
float o;
void cm();
void ft();
void in();
int main()
{
	cout<<"Que es lo que desea convertir?1-3"<<endl;
	cout<<"1. Centimetros"<<endl;
	cout<<"2. Pies"<<endl;
	cout<<"3. Pulgadas"<<endl;
	cin>>x;
	switch (x)
	{
		case 1:
		    cm();
		    break;
	    case 2:
		    ft();
		    break;
		case 3:
		    in();
		    break;
	}
    getch();
return 0;
}

void cm()
{
	cout<<"Seleccione la cantidad en centimetros"<<endl;
	cin>>x;
	n = (x/30.48);
	o = (x/2.54);
	cout<<"La conversion de centimetros a pies es de "<<n<<" pies"<<endl;
	cout<<"La conversion de centimetros a pulgadas es de "<<o<<" pulgadas"<<endl;
}
void ft()
{
	cout<<"Seleccione la cantidad en pies"<<endl;
	cin>>x;
	m = (x*30.48);
	o = (x*12);
	cout<<"La conversion de pies a centimetros es de "<<m<<" centimetros"<<endl;
	cout<<"La conversion de pies a pulgadas es de "<<o<<" pulgadas"<<endl;
}
void in()
{
	cout<<"Seleccione la cantidad en pulgadas"<<endl;
	cin>>x;
	m = (x*2.54);
	n = (x/12);
	cout<<"La conversion de pulgadas a centimetros es de "<<m<<" centimetros"<<endl;
	cout<<"La conversion de pulgadas a pies es de "<<n<<" pies"<<endl;
}
