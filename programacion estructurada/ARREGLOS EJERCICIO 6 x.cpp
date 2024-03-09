/*
Escribir un programa que lea un arreglo bidimensional de números enteros y que devuelva 
la suma de los elementos positivos de la matriz y la suma de los elementos negativos.
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
	int suma=0;
	int resta=0;
	int numero[3][3]={6,-5,2 , -1,10,3 , 4,-2,8};
	
	cout<<"Matriz Normal\n";
	for(int i=0;i<3;i++)
	{
		for(int j=0;j<3;j++)
		{
			cout<<numero[i][j]<<" ";
		}
		cout<<"\n";
	}
	 suma = numero[0][0] + numero[0][2] + numero[1][1] + numero[1][2] + numero[2][0] + numero[2][2];
	resta = numero[0][1] + numero[1][0] + numero[2][1];
	cout<<"La suma es "<<suma<<endl;
	cout<<"La resta es "<<resta<<endl;
    getch();
return 0;
}


