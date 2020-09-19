
using System.Security.AccessControl;
using System;
using System.Collections.Generic;

// TADS pila, colas, etc.

namespace arbolitodenavidad
{
    public class ArbolBinBusqueda {
      
        public Nodo raiz;
       
     

        public ArbolBinBusqueda()
        {
            this.raiz = null;            
        }

        public bool EstaVacio() {
            return (raiz==null);
        }

        public void Insertar(Nodo nodo) {
            Nodo nodoAux = null;

            if(nodo==null)
                throw new Exception("el nodo es NULL");

            if(EstaVacio()) {
                raiz = nodo;
            } else {
                nodoAux = raiz;
                while(true) {
                    if(nodo.dato < nodoAux.dato) {
                        if(nodoAux.izq!=null)
                            nodoAux = nodoAux.izq;
                        else {
                            nodoAux.izq = nodo;
                            break;
                        }
                    } else if(nodo.dato > nodoAux.dato) {
                        if(nodoAux.der!=null)
                            nodoAux = nodoAux.der;
                        else {
                            nodoAux.der = nodo;
                            break;
                        }
                    } else { //ya habia sido insertado
                        throw new Exception($"El nodo cond dato:{nodo.dato} ya habia sido insertado!");
                    }
                }
            }
        }
    
        public bool ExisteNodo(int dato) {
            Nodo nodo = null;
            Nodo nodoAux = null;

            nodo = new Nodo(dato);
            if(EstaVacio()) {
                return false;
            } else {
                nodoAux = raiz;
                while(true) {
                    if(nodo.dato==nodoAux.dato)
                        return true;
                    else if(nodo.dato<nodoAux.dato && nodoAux.izq!=null) {
                        nodoAux = nodoAux.izq;                        
                    }
                    else if(nodo.dato>nodoAux.dato && nodoAux.der!=null) {
                        nodoAux = nodoAux.der;
                    }
                    else {
                        return false;
                    }
                }
            }
        }
     

	

    
  
   
        public String darRecorridoInorden()
        {
            String cad = "";
            cad = recorrerInorden(raiz, cad);
            return cad;
        }

        private static String recorrerInorden(Nodo recorrer, String cad)
        {
            if (recorrer == null)
            {
                return cad;
            }
            cad = recorrerInorden(recorrer.izq, cad);
            cad = cad + recorrer.dato + ", ";
            cad = recorrerInorden(recorrer.der, cad);
            return cad;
        }
    public Nodo BuscarPadre(int dato)
        {
            return BuscarPadree(dato, raiz);
        }
    private Nodo BuscarPadree(int dato, Nodo nodo)
        {
            if (dato < nodo.dato)
            {
                if (nodo.izq!= null)
                {
                    if (dato == nodo.izq.dato)
                        return nodo;
                    else
                        return BuscarPadree(dato, nodo.izq);
                }
                else
                    return null;
            }
            else
            {
                if (nodo.der != null)
                {
                    if (dato == nodo.der.dato)
                        return nodo;
                    else
                        return BuscarPadree(dato, nodo.der);
                }
                else
                    return null;
            }
        }
         public void EliminarHoja(int dato)
        {   
            if(raiz.dato==dato){
               throw new Exception("es la raiz");    
            }else{

            
            if(ExisteNodo(dato)==true){
                Nodo padr = BuscarPadre(dato);
                Nodo aux=null;
                aux=padr;
                if(padr.der.dato==dato){
                    aux=aux.der;
                    if(aux.der==null && aux.izq==null){
                        padr.der=null;
                    }else{
                         throw new Exception("NO es una hoja");    
                    }
                    
                }
                else{
                    aux=aux.izq;
                    if(aux.der==null && aux.izq==null){

                        padr.der=null;
                    }
                    else{
                         throw new Exception("NO es una hoja");      
                    }
                }
            }
            else{
                Console.WriteLine("No Existe");
            }
            }
        }
      
      
          internal int ObtenerAlturaRecursivo(Nodo nodoActual)
        {
            int alturaIzquierda = 0;
            int alturaDerecha = 0;

            if (nodoActual == null)
            {
                return 0;
            }

            alturaIzquierda = ObtenerAlturaRecursivo(nodoActual.izq);
            alturaDerecha = ObtenerAlturaRecursivo(nodoActual.der);

            if (alturaIzquierda > alturaDerecha)
            {
                return alturaIzquierda + 1;
            }
            else
            {
                return alturaDerecha + 1;
            }
        }

        public  int altura (){
            return(ObtenerAlturaRecursivo(raiz));
        }
      
        public int AlturaxIzquierda(){
            return(ObtenerAlturaRecursivo(raiz.izq));
        }
        
       
     
        }
       
    }
