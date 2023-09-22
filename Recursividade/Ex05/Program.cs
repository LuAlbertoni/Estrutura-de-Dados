// A Série de Fibonacci pode ser definida da seguinte maneira:
//     se (n == 0 ou n == 1) retorna n
//     se (n >= 2) retorna fib(n – 1) + fib(n – 2)

// Seja fib(n) uma função que retorna o n-ésimo termo da série de Fibonacci, implemente uma versão recursiva e outra iterativa. Observe que a partir de um determinado número, a função recursiva começa a ficar mais lenta que a iterativa.

Console.Write("\nInsira um número: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nResultado (Recursivo): {fibonacciRecursivo(n)}");
Console.WriteLine($"Resultado (Iterativo): {fibonacciIterativo(n)}\n");

// Calcula o n-ésimo termo da série de Fibonacci (recursivo)
int fibonacciRecursivo(int n)
{
    if (n == 0 || n == 1)
        return n;
    else
        return fibonacciRecursivo(n - 1) + fibonacciRecursivo(n - 2);
}

// Calcula o n-ésimo termo da série de Fibonacci (iterativo)
int fibonacciIterativo(int n)
{
    int a = 0,
        b = 1,
        c = 0;

    for (int i = 0; i < n; i++)
    {
        c = a + b;
        a = b;
        b = c;
    }

    return c;
}
