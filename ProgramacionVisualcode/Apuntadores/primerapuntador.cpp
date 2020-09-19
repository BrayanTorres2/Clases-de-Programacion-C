#include <iostream>
using namespace std;
int main(){
    int a=0;
    int *p1=NULL;
    int **p2=NULL;
    a = 20;
    p1= &a;
    p2= &p1;
    cout<<a<<endl;
    **p2=60;
    cout<<a<<endl;
    return 0;
}