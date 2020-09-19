using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace radix
{
    class Program
    {
       
        static void Main(string[] args)
        { 
            TextWriter archivo;
            archivo = new StreamWriter("archivo.txt");
            //Multidimensional
            string original="\narreglo original";
            string primer_recorrido="\nPrimer Recorrido";
            
            int[,] arr2 = new int[2,3] {
                {-36,-6,16},
                {25,57,70}
            };
         
            int[,] copia = new int[2,3] {
                {1,1,1},
                {1,1,1}
            };

            archivo.WriteLine(original);
            //Console.WriteLine(arr2[1,1]);

            foreach(int i in arr2) {//recorre y imprime los valores del arreglo
                archivo.Write(" "+ i);
            }

             for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                if(arr2[i,j]<0){
                    copia[i,j]=arr2[i,j];
                    arr2[i,j]=arr2[i,j]*-1;
                    
                }
            }
            }
              

            int [ ][ ] arr3 = new int [10][]//creado un arreglo de arreglos para el radix
            {
            new int[ ] { 0, 0,0} ,
            new int[ ] { 0, 0,0} ,
            new int[ ] { 0, 0,0} ,
            new int[ ] { 0, 0,0} ,
            new int[ ] { 0, 0,0},
            new int[ ] { 0, 0,0} ,
            new int[ ] { 0, 0,0} ,
            new int[ ] { 0, 0,0} ,
            new int[ ] { 0, 0,0} ,
            new int[ ] { 0, 0,0}
            } ;
            //mensaje = console.ReadLine();
            //arr3[0,9]=90;

            //unidades
            foreach(int i in arr2) {//saca las unidades de un elemento 
                int j=i;
                int umil = j / 1000;
                int tmp = j % 1000;
                int centenas = tmp / 100;
                tmp = tmp % 100;
                int decenas = tmp / 10;
                int unidades = tmp % 10;
                if(arr3[unidades][0]==0){//si el arreglo en la posicion de las unidades es cero
                   arr3[unidades][0]=i; //remplacelo por el valor de i
                }
                else if(arr3[unidades][1]==0){//pasa al la segunda  posicion si la primera esta ocupada
                     arr3[unidades][1]=i;//remplaza por el valor de i
                }
                else{//si la primera y la segunda estan llenas pongale en la tercera
                    arr3[unidades][2]=i; //remplacelo por el valor de i
                }
            }  

            archivo.WriteLine(primer_recorrido);//imprime un mensaje

            foreach(int[] d1 in arr3) {//recorre las posiciones
                foreach(int d2 in d1) {//recorre los valore
                  archivo.Write(" "+d2);//imprime cada valor del arreglo
                }
            }

            foreach(int i in arr2) {//recorre los valores del arreglo 2
                int x1=0,y1=0;
               foreach(int[] d1 in arr3) {//recorre las posiciones
                foreach(int d2 in d1) {//recorre los valores
                    if(d2!=0){//si el valor es diferente de cero
                        if(y1>=3){//
                            y1=0;
                            x1=1;
                        }
                        arr2[x1,y1]=d2;//pongalo en la lista original
                        y1++;//aumenteme la variable
                    }
                    
                }

            }
        }
        for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    for (int x = 0; x < copia.GetLength(0); x++)
                     {
                      for (int y = 0; y < copia.GetLength(1); y++)
                      { 
                          if((copia[x,y]*-1)==arr2[i,j]){
                              arr2[i,j]=arr2[i,j]*-1;
                          }

                      }

                }
            }
            }

        archivo.WriteLine(original); //imprimame el texto 
        foreach(int i in arr2) {//recorra el arreglo original y imprimame cada valor
                archivo.Write(" "+i);
            }
        for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                if(arr2[i,j]<0){
                    copia[i,j]=arr2[i,j];
                    arr2[i,j]=arr2[i,j]*-1;
                    
                }
            }
            }
                  
        //Limpiar el arr3
        archivo.WriteLine("\nLimpiar el arr3");
        foreach(int i in arr2) {
                int j=i;
                int umil = j / 1000;
                int tmp = j % 1000;
                int centenas = tmp / 100;
                tmp = tmp % 100;
                int decenas = tmp / 10;
                int unidades = tmp % 10;
                arr3[unidades][0]=0;
                arr3[unidades][1]=0; 
                arr3[unidades][2]=0;
            } 

        foreach(int[] d1 in arr3) {//recorra el arreglo 3 y imprimame sus valores
                foreach(int d2 in d1) {
                  archivo.Write(" "+ d2);
                }
            } 
            
         //Decenas
            foreach(int i in arr2) {
                int j=i;
                int umil = j / 1000;
                int tmp = j % 1000;
                int centenas = tmp / 100;
                tmp = tmp % 100;
                int decenas = tmp / 10;
                if(arr3[decenas][0]==0){
                   arr3[decenas][0]=i; 
                }
                else if(arr3[decenas][1]==0){
                     arr3[decenas][1]=i;
                }
                else{
                    arr3[decenas][2]=i; 
                }
                
            }  
            archivo.WriteLine("\nSegundo Recorrido");
            foreach(int[] d1 in arr3) {
                foreach(int d2 in d1) {
                  archivo.Write(" "+d2);
                }
            }
            foreach(int i in arr2) {
                int x1=0,y1=0;
               foreach(int[] d1 in arr3) {
                foreach(int d2 in d1) {
                    if(d2!=0){
                        if(y1>=3){
                            y1=0;
                            x1=1;
                        }
                        arr2[x1,y1]=d2;
                        y1++;
                    }
                    
                }

            }
        }
        
         for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    for (int x = 0; x < copia.GetLength(0); x++)
                     {
                      for (int y = 0; y < copia.GetLength(1); y++)
                      { 
                          if((copia[x,y]*-1)==arr2[i,j]){
                              arr2[i,j]=arr2[i,j]*-1;
                          }

                      }

                }
            }
            }
           
        archivo.WriteLine(original);   
        foreach(int i in arr2) {
                archivo.Write(" "+i);
            }  

             for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                if(arr2[i,j]<0){
                    copia[i,j]=arr2[i,j];
                    arr2[i,j]=arr2[i,j]*-1;
                    
                }
            }
            }
              

        //Limpiar Arr3
        archivo.WriteLine("\nLimpiar el arr3");
        foreach(int i in arr2) {
                int j=i;
                int umil = j / 1000;
                int tmp = j % 1000;
                int centenas = tmp / 100;
                tmp = tmp % 100;
                int decenas = tmp / 10;
                arr3[decenas][0]=0;
                arr3[decenas][1]=0; 
                arr3[decenas][2]=0; 

            } 
        
        
        foreach(int[] d1 in arr3) {
                foreach(int d2 in d1) {
                  archivo.Write(" "+d2);
                }
            } 
        

            archivo.Close();
            Console.Clear();
            Console.WriteLine("Inicio del Radix");
            Console.WriteLine("Fin del Radix");
            string a="colombia";
            string b="calle 60";
            string re="usp_ObtenerCustomers1 ";
            string coma=",";
            string punto=";";
            string resultado=String.Concat(re,a,coma,b,punto);
            Console.WriteLine(resultado);
          
        
        }
    }
}
