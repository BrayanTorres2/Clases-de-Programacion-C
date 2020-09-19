using System;

namespace arbolitodenavidad{
public class Cola:MiLista {

	public Cola():base() {
		
	}

	public void encolar(int dato) {	
        Adicionar(dato);
	}

	public int? desencolar() {
        Nodo nodopos= ObteneryRemoverPrimero();
            if(nodopos!=null){
                 return nodopos.dato;
            }   
        return null;
           

	}

	public void mostrarCola() {
        Mostrar();
	}
}
}