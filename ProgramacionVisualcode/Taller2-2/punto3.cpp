#include <iostream>			
using namespace std;
int main(){
    int arr1[3][2]{
        {10,20},
        {30,40},
        {50,60}
    };
    int d1=2,d2=3;
    int **arr2=(int **)calloc(d2,sizeof(int **));
    for (int i=0;i<d2;i++){
        *(arr2+1)=(int *)calloc(d1,sizeof(int));
    }
    //3.3
    cout<<arr[1][0];//30
    cout<<*(*arr2+2)+0;//50
    //3.4
    cout<<arr2+2;//0x317
    cout<<(*(arr2+2)+0)//0x324
    //3.5
    free(*arr2)
    free(arr2)


    
}