/*
Escribir un programa que lea un arreglo unidimensional de 10 elementos. Deberá imprimir 
el mismo vector por pantalla pero invertido.  
Ejemplo:  
    Dado el arreglo 1 2 3 4 5 6 7 8 9 10  
    el programa debería imprimir 10 9 8 7 6 5 4 3 2 1.  
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
    int i;
    int x;
	int arreglo[10];
	for (i=0;i<10;i++)
	{
	    cout<<i+1<<". Dijite el numero"<<endl;
	    cin>>x;
	    arreglo[i] = x; 
	}
	cout<<"\nMatriz original -";
	for (i=0;i<10;i++)
	{
	    cout<<arreglo[i]<<"-";
	}
	cout<<"\nMatriz inversa - ";
	for (i=9;i>=0;i--)
	{
	    cout<<arreglo[i]<<"-";
	}
    getch();
return 0;
}
