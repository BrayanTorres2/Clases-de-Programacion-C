#include <iostream>
//#include <cstdlib>
using namespace std;
int main(){
    //calloc inicializa
    //reservar 1 partes, cada parte de tamaño int, y apuntador ese bloque con apuntador *p
    int *p=(int *)calloc(1,sizeof(int));
    *p=100;
    //Relocalizamos un nuevo espacio de memoria,ahora de 2 partes, cadaina de tipo int
    //y el apuntador *p apuntara a ese nuevo direccion
    p=(int *)realloc(p,2*sizeof(int));
    *(p+1)=200;//p[1]=200;
    cout<<*(p+0)<<endl;
    cout<<*(p+1)<<endl;
    //libera todos los espacios de memoria reservados y apuntados por *p
    free(p);
    p=NULL;
    

    return 0;
}