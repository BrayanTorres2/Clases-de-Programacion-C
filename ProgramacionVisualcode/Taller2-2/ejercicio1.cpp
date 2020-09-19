#include <iostream>
using namespace std;

double promedio(int tam, double sum, double *arre, double prom){

    for (int i = 0;i < tam; i++)
    {
       sum=sum+arre[i];
    }
    
    prom=sum/tam;
    
    return prom;
}

int main(){
    
    int tamano;
    cout<<"ingrese el tamano de la lista"<<endl;
    cin>>tamano;
    double suma=0;
    double * arr=(double *)malloc(10 * sizeof(double));//se considera como un apuntador de tipo arreglo
    
    int i = 0;
    double prome=0;
    
    while (i<tamano)
    {
        double num;
        cout<<"ingrese los numeros por a promediar por favor"<<endl;
        cin>>num;
        arr[i]=num;
        
        i++;

    }
    
    cout<<promedio(tamano,suma,arr,prome)<<endl;
    free (arr);

    return 0;
}