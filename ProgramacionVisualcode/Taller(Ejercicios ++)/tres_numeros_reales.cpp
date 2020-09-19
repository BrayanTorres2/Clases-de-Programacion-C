#include<iostream>

using namespace std;
 
int main()

{  double num,num2,num3;
  cout<<"\nIntroduce el numero 1: "<<endl;
   cin>>num;
   cout<<"\nIntroduce el numero 2: "<<endl;
   cin>>num2;
   cout<<"\nIntroduce el numero 3: "<<endl;
   cin>>num3;
   if(num>num2 && num>num3 ){
       printf("numero 1 es mayor");

   }
   else if(num2>num && num2>num3){
      printf("numero 2 es mayor");
   }
   else if(num3>num && num3>num2){
      printf("numero 3 es mayor");
   }
   else
   {
         printf("son iguales");
   }
   return 0;

}