/*
Escriba una función que determine si un carácter es uno de los dígitos 0,1,2. . . . .9. 
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
	cout<<"Dame un numero"<<endl;
	cin>>x;
}
void proceso()
{
	if(x>0 && x<10)
	{
		cout<<"El numero seleccionado es "<<x<<endl;
	}
	else
	{
		cout<<"ERROR"<<endl;
	}
}
