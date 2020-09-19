#include <iostream>
#include<string.h>
using namespace std;
void f1(char *p){
    strcat(p,",Piloso");
}
int main()
{
    char cadena[32]="Hola Compañero";
    f1(cadena);
    cout<<cadena<<endl;
    return 0;

}