using System;

namespace arbolitodenavidad
{
    public class MiLista
    {
        Nodo p;
        Nodo u;
        int tamano;

        public MiLista()
        {
            p = null;
            u = null;
            tamano = 0;            
        }

        public bool EstaVacia() {
            return (p==null && u==null);
        }

        public void Adicionar(int dato) {
            Nodo nodo = new Nodo(dato);
            if(EstaVacia()) {
                p = nodo;
                u = nodo;
            } else {
                u.der = nodo;
                u = nodo;
            }
            tamano +=1;
        }

        public void Mostrar() {
            Nodo nodoAux = null;
            int i=0;
            nodoAux = p;
            while(i++ < tamano) {
                Console.WriteLine(nodoAux.dato);
                nodoAux = nodoAux.der;
            }
        }

    public void RemoverPrimero() {
            Nodo nodoAux = null;

            if(!EstaVacia()) {
                if(tamano == 1) {
                    p = null;
                    u = null;
                } else { // por lo menos hay 2 nodos
                    nodoAux = p;
                    p = p.der;
                    nodoAux.der = null;                                        
                }
                tamano -= 1;
            }
        }

        public Nodo ObteneryRemoverPrimero() {
            Nodo nodoCopia = null;
            if(!EstaVacia()) {
                nodoCopia = new Nodo(p.dato);
                RemoverPrimero();
            }
            return nodoCopia;
        }
       
    
         public Nodo obtenerNodoxPosicion(int posi) {
            Nodo nodoAux = p;
           
            if(!EstaVacia()){
                for (int i=0; i<posi;i++){
                    nodoAux=nodoAux.der;
                }
            }
            return nodoAux;
            
        }
        

        public void insertarNodoxPosicion( int posi,Nodo nodo){ 
		    if(EstaVacia() && posi==0) {
			   p = nodo;
			   u = nodo;
			   tamano++;
		    }    
            else if(!EstaVacia() && posi==0) {
			    nodo.der = p;
			    p = nodo;
			    tamano++;
		    } 
            else if(!EstaVacia() && posi==tamano) {
			   u.der = nodo;
			   u = nodo;
			   tamano++;
		    } 
            else if(!EstaVacia() && (posi>0 && posi<tamano)) {  
               Nodo nodoAux = obtenerNodoxPosicion(posi - 1);
			   nodo.der = nodoAux.der;
			   nodoAux.der = nodo;
			   tamano++;
               /* 
               Nodo nodoAux3 =p;
               for (int i=0; i<posi-1;i++){
                    nodoAux3=nodoAux3.sgte;
                }
               nodo.sgte = nodoAux3.sgte;
			   nodoAux3.sgte = nodo;
			   tamano++;
               */ 
                               
            
		    } else {
                Console.WriteLine($"posición: {posi}  NO existe!");
		     	//throw new System.ArgumentException("que pasa", "que pasa...");
		    }
	    }
        public void insertarPrimero(Nodo nodo){
            insertarNodoxPosicion(0,nodo);		
        }

       
    }
}