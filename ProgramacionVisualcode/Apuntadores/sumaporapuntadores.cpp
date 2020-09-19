#include <iostream>
using namespace std;
int main()
{
    int arr[]={10,20};
    int *p=NULL;
    p=arr;
    cout<<*(p)+*(p+1)<<endl;

}