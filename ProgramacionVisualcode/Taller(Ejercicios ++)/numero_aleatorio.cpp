#include <stdlib.h>
#include <time.h>
#include<iostream>

using namespace std;
 
int main()

{
     int num, c;
      printf("Introduce el numero: ");
      scanf("%d",&num);
   
    srand(time(NULL));
    num = 1 + rand() % ((num+1)-1);
    printf("el random es: %u",num);
    
    return 0;
}