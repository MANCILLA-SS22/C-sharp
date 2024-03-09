/*
Escribir un programa que lea un arreglo bidimensional de enteros de 2 filas y 4 columnas y 
muestre por pantalla la traspuesta.  
Ejemplo: 
        Entrada: 2 3 4 5
                 7 6 5 4
     
	    Salida: 2 7
	            3 6
	            4 5
	            5 4

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
	int x[2][4] = {2,3,4,5 , 7,6,5,4};
	cout<<"Matriz original"<<endl;
	for(i=0;i<2;i++)
	{
		for(j=0;j<4;j++)
		{
			cout<<x[i][j];
		}
		cout<<"\n";
	}
	
	
	cout<<"Matriz transpuesta"<<endl;
	for(i=0;i<4;i++)
	{
		for(j=0;j<2;j++)
		{
			cout<<x[j][i];
		}
		cout<<"\n";
	}	
    getch();
return 0;
}
