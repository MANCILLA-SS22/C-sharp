/*
Escribir un programa que lea una arreglo bidimensional de 3 filas y 3 columnas de valores 
enteros.  A  continuaci�n,  el  programa  debe  pedir  el  n�mero  de  una  fila.  El  programa 
deber� devolver el valor m�ximo de esa fila. 
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
int main()
{
	int i,j;
	int mayor=0;
	int numero1;
	int numero2;
	int x[3][3]={1,2,3,4,5,6,7,8,9};
	for(i=0;i<3;i++)
	{
		for(j=0;j<3;j++)
		{
            x[2][j];
			if (mayor<x[2][j])
		    {

                mayor=x[2][j];
            }
		}
    }
    cout<<"El valor maximo de la fila es "<<mayor<<endl;
    getch();
return 0;
}

