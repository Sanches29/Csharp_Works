

//#include <iostream>
#include <stdio.h>
#include <time.h>

int main()
{
    clock_t start, end;
    start = 0;
    end = 0;
    printf("Este Programa retornara a soma dos numeros de 1 a 1000000: \n");

    long long soma = 0;

    start = clock();
    for (int i = 0; i <= 1000000; i++) {
        soma += i;
    }
    end = clock();

    double time_taken = double(end - start)/ double(CLOCKS_PER_SEC); //em segundos
    // double time_taken = double(end - start); em milisegundos

    printf("O resultado da soma eh: %lld \n", soma);
    printf("O tempo de execucao foi de: %f segundos", time_taken);
}

