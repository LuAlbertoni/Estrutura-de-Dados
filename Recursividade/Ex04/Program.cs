// Baseado no algoritmo de Euclides, implemente uma função recursiva para determinar o máximo divisor comum (mdc) entre dois números inteiros x e y.

// Algoritmo de Euclides:
//     se (x = y) retorna x
//     senão se (x < y) retorna mdc(y, x)
//     senão retorna mdc(x - y, y)

Console.Write("\nInsira o primeiro número: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Insira o segundo número: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nResultado: {mdc(x, y)}\n");

int mdc(int x, int y)
{
    if (y == 0)
        return x;
    else
        return mdc(y, x % y);
}
