#include <stdlib.h>
#include <time.h>
#include<iostream>
#include <conio.h>
using namespace std;
int main()

{
     int s1=0;
    int num=0, num1=0,suma1=0,suma2=0,suma3=0,a1=0,a2=0;
    while (s1<=5){
    cout<<"\nIntroduce el numero 1: "<<endl;
    cin>>num;
    srand(time(NULL));
    a1= 1 + rand() % (11-1);
    suma1=num+a1;
    cout<<"\nla suma es: ";
    cout<<suma1;
    cout<<"\nIntroduce el numero 2: "<<endl;
    cin>>num1;
    suma2=suma1+num1;
    
    cout<<"\nLa suma es: ";
    cout<<suma2;
    s1++;
     }
    return 0;
}