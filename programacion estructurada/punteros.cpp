#include <iostream>
#include <conio.h>
using namespace std;
char y[]={'a','e','i','o','u'};
char *ptrF=NULL;
char valor;
int x;
int main()
{
    cout<<"Dame el numero del 1 al 5: ";
    cin>>x;
    ptrF=&valor;
    *ptrF=y[x-1];
    cout << "El caracter de la localidad es: "<<valor<<endl;
    cout<<"La localizacion es :"<<&ptrF;
    return 0;
}

