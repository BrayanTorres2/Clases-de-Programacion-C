# include <iostream>
using namespace std;
int main(){
    int i1=0;
    char cadena1[10]="";
    cout <<"num: "<<endl;
    cin>>i1;
    cin.ignore();
    cout<<"cadena1 "<<endl;
    cin.getline(cadena1,10);
    cout<<cadena1<<endl;
    return 0;
}
