    
#include <iostream>
using namespace std;

void copiar(int *p, int *c, int tamano) {
    int i=0;
    while (i<tamano){
           c[i] = p[i];
        i++;
    }
}
void mostrar(int *p, int tamano) {
     int i=0;
    while (i<tamano){
         cout<<p[i]<<endl;
        i++;
    }
   


}

void f1(int *p) {
    p[1] = 50;
}

int main() {
    int tamano = 3;
    int original[tamano] = {10,20,30};
    int aux[tamano] = {0};

    copiar(original, aux, tamano);
    f1(aux);
    mostrar(aux, tamano);

    return 0;
}