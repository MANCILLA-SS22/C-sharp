/*	
Escribir un programa que pida 10 n�meros enteros por teclado, lo guarde en un arreglo y 
que imprima por pantalla: 
a) Cu�ntos de esos n�meros son pares. 
b) Cu�l es el valor del n�mero m�ximo. 
c) Cu�l es el valor del n�mero m�nimo. 
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
	int y;
	int i;
	int a,b;
	int par;
	int impar;
    int mayor=0;
    int menor=10000000;
    int x[10];
    
	for(i=0;i<10;i++)
	{
		
		cout<<i+1<<". Escribe un numero"<<endl;
		cin>>x[i];
		 if(x[i] > mayor)
		 {
		 	mayor = x[i]; 
		 }
		 if(x[i] < menor)
		 {
		 	menor = x[i]; 
		 }
	}
	cout<<"La cantidad de pares es de "<<a<<" numeros"<<endl;
	cout<<"La cantidad de impares es de "<<b<<" numeros"<<endl;
	cout<<"El numero mayor del vector es "<<mayor<<endl;
	cout<<"El numero menor del vector es "<<menor<<endl;
	getch();
return 0;
}
