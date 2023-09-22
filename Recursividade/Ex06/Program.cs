// Defina uma função recursiva que converte um número inteiro para a base binária.

Console.Write("\nInsira um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nResultado: {bin(num)}\n");

string bin(int num)
{
    if (num == 0)
        return "0";
    else
        return bin(num / 2) + (num % 2).ToString();
}
