
#include <iostream>			
using namespace std;
			
struct OrdenCompra {
	int numero;
	char fecha[16];
    int valor;
	};
			
 struct Proveedor {
  int nit;
  char nombre[32];
  int cantOrdenCompras;
  OrdenCompra *OrdenCompras;
};
double totalizarOC(OrdenCompra *oc,int cantidadOC){
    double suma=0;
    double total=0;
    for (j=0,j<cantidadOC;j++){
        suma=sum+OrdenCompra[j].valor;
    }
    total=suma*cantidadOC;
    return total;
}
                    
int main() {
    int cantProveedors = 0, cantOrdenCompras = 0, valor=0;
    Proveedor *Proveedors = NULL;
    OrdenCompra *OrdenCompras = NULL;
                    
    cout<<"Entre Cantidad Proveedors: ";
        cin>>cantProveedors;
                    
    //Proveedors = (Proveedor *)malloc(cantProveedors * sizeof(Proveedor));
    Proveedors = new Proveedor[cantProveedors];    
    for (int i = 0; i < cantProveedors; ++i) {
    cout<<"entre nit: ";
    cin>>Proveedors[i].nit;
    cin.ignore();
    cout<<"entre nombre: ";
    cin.getline(Proveedors[i].nombre, 32);
    cout<<"Entre cantidad de OrdenCompras: ";
    cin>>cantOrdenCompras;
    Proveedors[i].cantOrdenCompras = cantOrdenCompras;
    OrdenCompras = (OrdenCompra *)malloc(cantOrdenCompras * sizeof(OrdenCompra));
    int j=0;
    for (int j = 0; j < cantOrdenCompras; ++j) {
        cout<<"entre numero: ";
        cin>>OrdenCompras[j].numero;
        cin.ignore();
        cout<<"entre fecha: ";
        cin.getline(OrdenCompras[j].fecha, 16);
        cout<<"valor de producto";
        cin>>OrdenCompras[j].valor;
    }
    totalizarOC(OrdenCompra *oc,cantOrdenCompras);
    Proveedors[i].OrdenCompras = OrdenCompras;
    }
    OrdenCompras = NULL;
    cout<<"Estos Son los Datos!!!"<<endl;
    for (int i = 0; i < cantProveedors; ++i) {
    cout<<"\t\tnit del Proveedor("<<i+1<<"): "<<Proveedors[i].nit<<endl;
    cout<<"\t\tnombre del Proveedor("<<i+1<<"): "<<Proveedors[i].nombre<<endl;
    for (int j = 0; j < Proveedors[i].cantOrdenCompras; ++j) {
    cout<<"\t\t\tnumero de la OrdenCompra: "<<Proveedors[i].OrdenCompras[j].numero<<endl;
    cout<<"\t\t\tfecha de la  OrdenCompra: "<<Proveedors[i].OrdenCompras[j].fecha<<endl;
    }
    free(Proveedors[i].OrdenCompras);
    Proveedors[i].OrdenCompras = NULL;
    }
    free(Proveedors);
    Proveedors = NULL;
    return 0;
    }
