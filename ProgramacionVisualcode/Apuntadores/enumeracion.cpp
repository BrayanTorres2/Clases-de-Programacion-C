#include <iostream>
#include<string.h>
#include <math.h>
using namespace std;

void f1(int *p,int i){
    p=&i;

}

void f2(int **p,int i){
    *p=&i;
}
int main()
{   
    int a = 100;
    int*p=NULL;
    p=&a;
    f1(p,30);
    cout<<"1"<<*p<<endl;
    f2(&p,30);
    cout<<"2"<<*p<<endl;

    return 0;
}

