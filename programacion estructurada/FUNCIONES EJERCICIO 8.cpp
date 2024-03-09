/*
Escriba una  función que convierta grados Centígrados a grados Fahrenheit  (Fahrenheit = 
grados * 9.0/5.0 + 32.0). 
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
float x;
float y;
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
	cout<<"Dame la cantidad que grados centigrados"<<endl;
	cin>>x;
}
void proceso()
{
	y = x*1.8 + 32;
	cout<<"La convercion de grados celcius a farhenheit es "<<y<<endl;
}
