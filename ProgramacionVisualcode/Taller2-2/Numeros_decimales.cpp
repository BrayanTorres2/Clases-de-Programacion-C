#include <iostream>
#include<stdio.h>
using namespace std;
 /*
Dado por el usuario una cantidad de números decimales (double), entonces:
• Cree un arreglo con asignación dinámica de memoria, de una dimensión y de ese
tamaño dado.
• El usuario debe entrar cada número.
• Debe existir una función que reciba el arreglo y retorne el promedio (como doublé de
2 decimales).
• Se debe mostrar el promedio obtenido.
*/

 double promedio(*arreglo,int tamano){
    //double tamano=0;
    //tamano=sizeof(arreglo) / sizeof(int);
    suma=0;
    for ( i = 0 ; arreglo[i]!=arreglo[tamano-1] ; i++ ){
        suma=arreglo[i]+arreglo[i+1];
    }
 }

 int main (){
     double cantidad,numero;
     cout<<"introdusca cantidad:"<<endl;
     cin>>cantidad;
      int arr1[cantidad]=(int *)calloc(1,sizeof(int));
     while(cantidad!=0){
       cout<<"introdusca numero:"<<endl;
       cin=numero;
       for ( i = 0 ; i<=cantidad; ; i++ ){
           arreglo[i]=arreglo[numero]
    }
       
     cantidad--;
     }
 
   f1(arr1);

 }
