#include <iostream>
#include <fstream>
using namespace std;
int main(){
    /*
    capturar un numero entero y mostrar descendentemente cada numero hasta 0
     */
 int num=0;
 cout<<"intruduzca un numero: "<<endl;
 cin>>num;
 for (int i = num;i >=0;i--){
        cout<<i<<endl;
    }

return 0;
}