#include<iostream>
#include<conio.h>
#include<stdio.h>
#include<windows.h>
#include<math.h>
#include<iomanip>
#include<cstdlib>
#include <string> 

using namespace std;
int x[4][4];
int fila1;
int fila2; 
int y;
int i;
int j;
int main()
{
    for (i=0;i<4;i++)
    {
        for (j=0;j<4;j++)
        {
            cout<<"Dame los valores de la matriz [" << i << "][" << j << "] ";
            cin>>x[i][j];
        }
    }
    cout<<"\n";
    for(i=0;i<4;i++)
    {
        for(j=0;j<4;j++)
        {
            cout<<x[i][j]<< " ";
        }
        cout<<"\n";
    }
    cout<<"Dame la fila #1 que quiere intercambiar "<<endl;
    cin>>fila1;
    cout<<"Dame la fila #2 que quiere intercambiar "<<endl;
    cin>>fila2;

    for(i=0;i<4;i++)
    {
        y = x[fila1 -1][i];
        x[fila1-1][i] = x[fila2-1][i];
        x[fila2-1][i] = y;
    }
    for(i=0;i<4;i++)
    {
        for(j=0;j<4;j++)
        {
            cout<<x[i][j] << " ";
        }
        cout<<"\n";
    }
    return 0;
}
