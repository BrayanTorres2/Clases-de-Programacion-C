#include <iostream>
using namespace std;

int main()

{
    int num1,num2;

cout<<"\nIntroduce numero"<<endl;
cin>>num1;

 if (num1>=1000){
     num2=(((num1%1000)%100)%10);
}
else if(num1>=100){
    num2=((num1%100)%10);
    }
else if(num1>=10){
    num2=num1%10;
}
else{
    num2=num1;
}

if(num1%2 == 0){
    cout<<"\nNo tiene ningun numero"<<endl;
}
else{
    cout<<"\nSi tiene el numero :"<<endl;
    cout<<num2;
}
return 0;
}