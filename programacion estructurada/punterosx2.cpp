/*
Implementar un algoritmo de ordenamiento utilizando apuntadores.  
MANCILLA CHAVEZ GERMAN
*/

#include<iostream>
#include<conio.h>
#include<stdio.h>
#include<windows.h>
#include<math.h>
#include<iomanip>
#include<cstdlib>
#include <string> 
#include<stdlib.h>
using namespace std;

int i,j;
int aux;
int num_elementos;
int *elemento;


void dato();
void num_orden(int, int*);
void imprimir_arreglo(int, int*);

int main()
{
	dato();
	num_orden(num_elementos,elemento);	
	imprimir_arreglo(num_elementos, elemento);
	
	delete[] elemento;
	getch();
	return 0;
}

void dato()
{
	cout<<"Digite el numero de elementos: ";
	cin>>num_elementos;
	
	elemento = new int[num_elementos];
	
	for(i=0;i<num_elementos;i++)
	{
		cout<<"Digite un numero ["<<i<<"]: ";
		cin>>*(elemento+i);
	}
}

void num_orden(int num_elementos, int *elemento)
{
	for(i=0;i<num_elementos;i++)
	{
		for(j=0;j<num_elementos-1;j++)
		{
			if(*(elemento+j) > *(elemento+j+1))
			{
				aux = *(elemento+j);
				*(elemento+j) = *(elemento+j+1);
				*(elemento+j+1) = aux;
			}
		}
	}
}

void imprimir_arreglo(int num_elementos, int *elemento)
{
	cout<<"\n\nMostrando Arreglo Ordenado: ";
	for(i=0;i<num_elementos;i++)
	{
		cout<<*(elemento+i)<<" ";
	}
}
