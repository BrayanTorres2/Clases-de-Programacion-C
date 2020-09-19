#include <iostream>
using namespace std;
int main(){
    cout<<"ejercicio9 \n";
    float num1, num2, num3;
    cout<<"por favor escriba un numero \n";
    cin >>num1;
    cout<<"por favor escriba otro numero \n";
    cin>> num2;
    cout<<"por favor escriba otro numero \n";
    cin>> num3;

    if (num1>num2 && num1>num3 && num2>num3){
        cout<< "el mayor es: "<<num1<<" el de en medio es: "<<num2<<" el menor es: "<<num3;
    }if (num1>num2 && num1>num3 && num2<num3){
        cout<< "el mayor es: "<<num1<<" el de en medio es: "<<num3<<" el menor es: "<<num2;
    }if (num2>num1 && num2>num3 && num1>num3){
        cout<< "el mayor es: "<<num2<<" el de en medio es: "<<num1<<" el menor es: "<<num3;
    }if (num2>num1 && num2>num3 && num1<num3){
        cout<< "el mayor es: "<<num2<<" el de en medio es: "<<num3<<" el menor es: "<<num1;
    }if (num3>num1 && num3>num2 && num1>num2){
        cout<< "el mayor es: "<<num3<<" el de en medio es: "<<num1<<" el menor es: "<<num2;
    }if (num3>num1 && num3>num2 && num1<num2){
        cout<< "el mayor es: "<<num3<<" el de en medio es: "<<num2<<" el menor es: "<<num1;
    }if (num1==num2 ){
        cout<<num1<<" es igual a "<<num2;
    }if (num1==num3){
        cout<<num1<<" es igual a "<<num3;
    }if (num2==num3){
        cout<<num3<<" es igual a "<<num2;
    }

    return 0;
    }