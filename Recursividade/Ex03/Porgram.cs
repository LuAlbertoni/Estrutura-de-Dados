// Implemente uma versão recursiva da seguinte função iterativa. Faça a repetição recursiva somente do for, não precisa fazer da expressão i * i * i.
// void cubos (int n)

// {

// for (int i = 1; i <= n; i++)

// Controle.WrilteLine(i * i * i);

// }

Console.Write("\nInsira um número: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nResultado: {cubo(num, 1)}\n");

int cubo(int x, int y)
{
    if (y == 3)
        return x;
    else
        return x * cubo(x, y + 1);
}
