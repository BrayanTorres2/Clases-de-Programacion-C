#include <iostream>
#include <fstream>
using namespace std;
int main(){
 int num=0;
 cout<<"intruduzca un palabra: "<<endl;
 cin>>num;
      ifstream rfile;
       char linea[50]="";
        rfile.open("C:\\Users\\Brayan Torrwa\\Desktop\\ProgramacionVisualcode\\Primeraclase\\nombre.txt", ios::in);
        while (rfile.getline(linea,50))
        {
        rfile<<num;
        }
         rfile.close();
return 0;
}