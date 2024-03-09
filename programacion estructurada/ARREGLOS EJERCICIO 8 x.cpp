/*
Escribir un programa que lea una arreglo bidimensional de 4 filas y 3 columnas, la visualice 
por pantalla y a continuación encuentre el mayor y el menor elemento del arreglo y sus 
posiciones. 
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
    int matriz[4][3]={10,12,13,14,15,1,2,3,77,2,1,0};
    int mayor=0;
    int numero1,numero2;

    for(int i=0;i<4;i++)
	{
		for (int j=0;j<3;j++)
		{
			matriz[i][j];

        if (mayor<matriz[i][j])
		    {

                mayor=matriz[i][j];
                numero1=i;
                numero2=j;
            }
        }
	}
    cout << "El numero mayor es: "<<mayor<<endl;
    cout << "Esta en la posicion: ("<< numero1<< ","<<numero2<< ") De la matriz"<<endl;
    return 0;
}



