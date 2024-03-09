/*
Realizar un programa que pida dos números enteros por teclado y muestre por pantalla el 
siguiente menú: 
1. Suma 
2. Resta 
3. Multiplicación 
4. División 
5. Potencia
6. Factorial 
7. Salir 
Elija opción: 
El  usuario  deberá  elegir  una  opción,  introducir  dos  valores  y  el  programa  deberá  mostrar  el 
resultado por pantalla. Todas las opciones (1 a 6) deben realizarse utilizando funciones. 
*/

#include<iostream>
#include<conio.h>
#include<math.h>
using namespace std;

float num1;
float num2;
int x;
int n;
int factorial=1;
float resp;
void dato();
void sum();
void res();
void multi();
void div();
void pot();
void fac();

int main()
{
	cout<<"Seleccione un metodo 1-6\n";
	cout<<"1. Suma"<<endl;
	cout<<"2. Resta"<<endl;
	cout<<"3. Multiplicacion"<<endl;
	cout<<"4. Division"<<endl;
	cout<<"5. Potencia"<<endl;
	cout<<"6. Factorial"<<endl;
	cin>>x;
	switch (x)
	{
		case 1:
		    sum();
		    break;
	    case 2:
		    res();
		    break;
		case 3:
		    multi();
		    break;
		case 4:
		    div();
		    break;
		case 5:
		    pot();
		    break;
		case 6:
		    fac();
		    break;
	}
	getch();
    return 0;
}
void sum()
{
	cout<<"Selecciona el primer numero"<<endl;
	cin>>num1;
	cout<<"Selecciona el segundo numero"<<endl;
	cin>>num2;
	resp = num1 + num2;
	cout<<"La suma es "<<resp<<endl;
}
void res()
{
	cout<<"\nSelecciona el primer numero"<<endl;
	cin>>num1;
	cout<<"Selecciona el segundo numero"<<endl;
	cin>>num2;
	resp = num1 - num2;
	cout<<"La resta es "<<resp<<endl;
}
void multi()
{
	cout<<"\nSelecciona el primer numero"<<endl;
	cin>>num1;
	cout<<"Selecciona el segundo numero"<<endl;
	cin>>num2;
	resp = num1 * num2;
	cout<<"La multiplicacion es "<<resp<<endl;
}
void div()
{
	cout<<"\nSelecciona el primer numero"<<endl;
	cin>>num1;
	cout<<"Selecciona el segundo numero"<<endl;
	cin>>num2;
	resp = num1 / num2;
	cout<<"La division es "<<resp<<endl;
}
void pot()
{
	cout<<"\nSelecciona el primer numero"<<endl;
	cin>>num1;
	cout<<"Selecciona la potencia"<<endl;
	cin>>num2;
	resp = pow (num1,num2);
	cout<<"La potencia del numero es "<<resp<<endl;
}
void fac()
{
	cout<<"Digite un numero para el factorial"<<endl; 
	cin>>n;
	for(int i=1;i<=n;i++){
		factorial *= i;
	}
	cout<<"El factorial del numero es: "<<factorial<<endl;
}

