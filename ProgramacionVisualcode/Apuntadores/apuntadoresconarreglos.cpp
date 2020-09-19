#include <iostream>
using namespace std;
void f1(int *p1){
    //*(p1+1)=50; cambiar el valor de (la posicion 1) a 50
    cout <<p1[1]<<endl;//notacion arrelo 
    cout <<*(p1+1)<<endl;//notacion de apuntadores
}
int main(){
   int arr1[3]={10,20,30};
   f1(arr1);
   return 0;
}