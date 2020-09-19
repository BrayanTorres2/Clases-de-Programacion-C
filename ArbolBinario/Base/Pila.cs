using System;

namespace arbolitodenavidad{
public class Pila:MiLista {

	public Pila() {
		
	}

	public void Apilar(int dato) {
        insertarPrimero(new Nodo(dato));	
	}

       

    public int? Desapilar() {
        Nodo nodopos= ObteneryRemoverPrimero();
            if(nodopos!=null){
                 return nodopos.dato;
            }   
        return null;	
	}

	public void mostrarPila() {
        Mostrar();
    }
	}
}
