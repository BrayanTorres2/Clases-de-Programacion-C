using System;

namespace arbolitodenavidad
{
    public class Nodo {
        public Nodo izq;
        public Nodo der;
        public int dato;

        public Nodo(int dato)
        {
            this.dato = dato;
            this.izq = null;
            this.der = null;
        }
    }
}