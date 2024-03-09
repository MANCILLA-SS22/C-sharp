/*
Utilizando la  función primo realizada en el Ejercicio 1, realizar un programa que muestre 
por pantalla todos los números primos comprendidos entre 1 y un número n introducido 
por teclado por el usuario. 
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
void dato();
void instruccion();
int numero;
int y;
int x;
int z;
bool resp;
int main()
{
	dato();
	instruccion();
    return 0;
}
void dato()
{
	cout<<"Dame un numero limite"<<endl;
	cin>>numero;
}
void instruccion()
{
	x = 2;
    while (numero>0) 
	{
        z = 1;
        for (y=2;y<x;++y) 
		{
            if (x%y == 0) 
			{
                z = 0;
            }
        }
        if (z)
		{
            cout<<"\n"<<x;
            numero--;
        }
        x++;
    }
}


