#include <iostream>
using namespace std;
int muestramensaje(int a){  
return (a+1);
}
int main(){
int (*p)(int)=NULL;
p=&muestramensaje;
int b=0;
b=(*p)(50);
cout<<b<<endl;
  return 0;
}