#include <iostream>
#include <stdlib.h>
using namespace std;
int main()
{
    int longitud;
    int cont = 0;
    cout << "Introduzca el tamano del arreglo: ";
    cin >> longitud;
    int *vectord = new int[longitud];
    for(int i = 0; i < longitud; i++) 
    {
        cout << "introduzca numero" ;
        cin >> vectord[i];
        cont++;
    }
// adicionar------
    int numero=0;
    cout << "cuantos mas quiere introducir " ;
    cin >> numero;
    longitud = longitud + numero;
    int *aux = new int[longitud];
    for(int i = 0; i < longitud ; i++)
    {
        aux[i] = vectord[i];
    }
    delete[] vectord;
    vectord = aux;
    for(int i = cont; i < longitud ; i++) /*Introducimos valores a partir de la última posición */
    {
        cout << "numeros adicionales" ;
        cin >> vectord[i];
        cout << vectord[i]; 
    }

    // fin de la adicion 
}

