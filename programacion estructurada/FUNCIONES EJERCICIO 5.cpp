/*
Escriba una función que lea tres números enteros del teclado y nos devuelva el mayor.
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
int y;
int z;
int mayor;
void dato();
void proceso();
int main()
{
	dato();
	proceso();
    getch();
return 0;
}
void dato()
{
	cout<<"Dame el primer numero"<<endl;
	cin>>x;
	cout<<"Dame el segundo numero"<<endl;
	cin>>y;
	cout<<"Dame el tercer numero"<<endl;
	cin>>z;
}
void proceso()
{
	if(x>y && x>z)
	{
		cout<<"\nEl numero mayor es "<<x<<endl;
	}
	if(y>x && y>z)
	{
		cout<<"\nEl numero mayor es "<<y<<endl;
	}
	if(z>x && z>y)
	{
		cout<<"\nEl numero mayor es "<<z<<endl;
	}
}
