/*
Escribir un programa que pida un n�mero por teclado y nos diga si ese n�mero es primo. 
El programa deber� utilizar una funci�n definida por el usuario, la cual reciba un n�mero y 
nos devuelva un 0 en el caso de que el n�mero que le pasemos no sea primo, y un 1 en 
caso contrario. 
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
int i;
int x;
int main()
{
	dato();
	instruccion();
    return 0;
}
void dato()
{
	cout<<"Dame un numero"<<endl;
	cin>>numero;
}
void instruccion()
{
	for(i=1; i<=numero; i++)
	{
		if(numero%i==0)
		{
			x++;
		}
	}
if(x==2)
    {
cout<<"Es primo";
    }
else
    {
cout<<"No es primo";
    }
}
