// Escreva uma função recursiva chamada potencia(x, y), que retorne a base x elevado ao expoente y.

Console.Write("\nInsira a base: ");
int baseNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Insira o expoente: ");
int expoente = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nResultado: {pot(baseNum, expoente)}\n");

int pot(int x, int y)
{
    if (y == 0)
        return 1;
    else
        return x * pot(x, y - 1);
}
