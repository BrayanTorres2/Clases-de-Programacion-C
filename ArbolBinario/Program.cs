using System;
using arbolitodenavidad;

namespace arbolitodenavidad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Prueba_Arbol_Insertar();
        }

        public static void Prueba_Arbol_Insertar() {
            ArbolBinBusqueda arbol = new ArbolBinBusqueda();
             arbol.Insertar(new Nodo(50));
             arbol.Insertar(new Nodo(40));
             arbol.Insertar(new Nodo(65));
             arbol.Insertar(new Nodo(60));
             arbol.Insertar(new Nodo(5));
             arbol.Insertar(new Nodo(8));
             arbol.Insertar(new Nodo(6));
           
             //arbol.EliminarHoja(210);
             //arbol.EliminarHoja(70);
            
             //Console.WriteLine(arbol.darRecorridoInorden());
             Console.WriteLine(arbol.AlturaxIzquierda());
             //Console.WriteLine(arbol.altura());

        }
    }
}
