/*
Escribir un programa que pida un n�mero natural por teclado y nos diga si ese n�mero es 
perfecto (un n�mero natural es perfecto si es igual a la suma de sus divisores, excluido �l 
mismo). El programa deber� utilizar una funci�n definida por el usuario, a la que se le pase 
un  n�mero  y  nos  devuelva  un  0  en  el  caso  de  que  el  n�mero  que  le  pasemos  no  sea 
perfecto, y un 1 en caso contrario. 
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
void dato ();
void proceso();
int num ;
int z = 0;
int x;
int main()
{
	dato ();
	proceso();
getch();

return 0;
}
void dato ()
{
	cout<<"Dame un numero"<<endl;
	cin>>num;
	system("cls");
}
void proceso()
{

	for(x=1;x<num;x++)
	{
		if(num % x == 0) z += x;
	}
	if(num == z)
	{
		cout<<"es primo :v"<<endl;
	}
	else
	{
		cout<<"no es primo :'v'"<<endl;
	}
}
