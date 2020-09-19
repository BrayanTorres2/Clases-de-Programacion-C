    
#include <iostream>
using namespace std;
int main()
{
    int x=100;
    int y=200;

    int *p1=NULL;
    int *p2=NULL;
    int **p3=NULL;
    int *p4=NULL;
    int **p5=NULL;
    p4=&x;
    p5=&p4;

    p1=&x;
    p2=&y;
    p3=&p2;
    **p3=**p5;
    //p3=&p2;
    //p3=&p1;
    //**p3=*p1;



    cout<< *p1 <<endl;
    return 0;
    
}