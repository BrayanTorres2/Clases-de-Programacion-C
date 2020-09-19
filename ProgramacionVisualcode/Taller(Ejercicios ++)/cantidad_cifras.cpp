#include <stdio.h>
#include <conio.h>
 
int main()
{
    int num,contador=1;
    printf("Introduce el numero: ");
    scanf("%d",&num);
    while(num/10>0)
    {
        num=num/10;
        contador++;
    }
    printf("Tiene %u caracteres",contador);

    return 0;
}