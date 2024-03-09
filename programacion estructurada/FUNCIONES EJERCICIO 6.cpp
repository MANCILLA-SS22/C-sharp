/*
Escriba una función que calcule la suma de los divisores de un número entero positivo. 
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
	y=1;
    for (z=2;z<=(x/2);z++)
	{
        if (x%z==0) 
	    {
            y=y+z;
        }
    }
    y=y+x;
    cout <<"La suma de los divisores de "<<x<<" es "<<y<<endl;
}
