#include<iostream>
#include<conio.h>
#include<stdio.h>
#include<windows.h>
#include<math.h>
#include<iomanip>
#include<cstdlib>
#include<string.h> 
#include<stdlib.h> 
using namespace std;
float calImp(float x); 
int main()
{
    float horas1,horas2,horas3,importe1,importe2,importe3,totalHoras,totalImporte;
    cout<<"Horas del automovil 1: ";
    cin>>horas1; 
    cout<<"Horas del automovil 2: ";
    cin>>horas2;
	cout<<"Horas del automovil 3: ";
    cin>>horas3;   
    cout<<"Automovil     Horas    importe"<<endl;
    cout<<"1"<<"               "<<horas1<<"        "<<importe1<<endl;
    cout<<"2"<<"               "<<horas2<<"        "<<importe2<<endl;
    cout<<"3"<<"               "<<horas3<<"        "<<importe3<<endl;
    importe1 = calImp(horas1);
    importe2 = calImp(horas2);
    importe3 = calImp(horas3);
    totalHoras = horas1+horas2+horas3;
    totalImporte = importe1+importe2+importe3;
    cout<<"Total de horas =  "<<totalHoras<<endl;
	cout<<"Total de importe = "<<totalImporte<<endl;
    return 0;
}
float calImp(float x)
{
	
}
