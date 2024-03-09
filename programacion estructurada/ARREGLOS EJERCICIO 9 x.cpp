/*
Escribir  un  programa  que  lea  una  frase  y  determine  la  frecuencia  de  aparición  de  cada 
vocal con respecto al total de caracteres de la frase. 
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
	char frase [100];
    int I;
    int J;
    int vocales=0;
    int consonantes=0;
    int total=0;
	int a=0,e=0,i=0,o=0,u=0;
	int b=0,c=0,d=0,f=0,g=0,h=0,j=0,k=0,l=0,m=0,n=0,p=0,q=0,r=0,s=0,t=0,v=0,w=0,x=0,y=0,z=0;
	cout<<"Dame una frase "<<endl;
	cin.getline(frase,100,'\n');
	
	for(I=0;I<30;I++)
	{
		switch (frase[I])
		{
			case 'a': a++; break;
			case 'e': e++; break;
			case 'i': i++; break;
			case 'o': o++; break;
			case 'u': u++; break;
			case 'b': b++; break;
			case 'c': c++; break;
			case 'd': d++; break;
			case 'f': f++; break;
			case 'g': g++; break;
			case 'h': h++; break;
			case 'j': j++; break;
			case 'k': k++; break;
			case 'l': l++; break;
			case 'm': m++; break;
			case 'n': n++; break;
			case 'p': p++; break;
			case 'q': q++; break;
			case 'r': r++; break;
			case 's': s++; break;
			case 't': t++; break;
			case 'v': v++; break;
			case 'w': w++; break;
			case 'x': x++; break;
			case 'y': y++; break;
			case 'z': z++; break;
		}
		vocales = a+e+i+o+u;
		consonantes =b+c+d+f+g+h+j+k+l+m+n+p+q+r+s+t+v+x+y+z;
		total = a+e+i+o+u+b+c+d+f+g+h+j+k+l+m+n+p+q+r+s+t+v+x+y+z;
	}
	cout<<"Vocal a: "<<a<<endl;
	cout<<"Vocal e: "<<e<<endl;
	cout<<"Vocal i: "<<i<<endl;
	cout<<"Vocal o: "<<o<<endl;
	cout<<"Vocal u: "<<u<<endl;
	cout<<"Vocal u: "<<u<<endl;
	cout<<"consonante b "<<b<<endl;
	cout<<"consonante c "<<c<<endl;
	cout<<"consonante d "<<d<<endl;
	cout<<"consonante f "<<f<<endl;
	cout<<"consonante g "<<g<<endl;
	cout<<"consonante h "<<h<<endl;
	cout<<"consonante j "<<j<<endl;
	cout<<"consonante k "<<k<<endl;
	cout<<"consonante l "<<l<<endl;
	cout<<"consonante m "<<m<<endl;
	cout<<"consonante n "<<n<<endl;
	cout<<"consonante p "<<p<<endl;
	cout<<"consonante q "<<q<<endl;
	cout<<"consonante r "<<r<<endl;
	cout<<"consonante s "<<s<<endl;
	cout<<"consonante t "<<t<<endl;
	cout<<"consonante v "<<v<<endl;
	cout<<"consonante w "<<w<<endl;
	cout<<"consonante x "<<x<<endl;
	cout<<"consonante y "<<y<<endl;
	cout<<"consonante z "<<z<<endl;
	cout<<"Cantidad total de consonantes: "<<consonantes<<endl;
	cout<<"Cantidad total de vocales: "<<vocales<<endl;
	cout<<"Cantidad total de letras: "<<total<<endl;
    getch();
return 0;
}


