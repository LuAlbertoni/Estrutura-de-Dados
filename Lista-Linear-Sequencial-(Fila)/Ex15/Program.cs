// Escreva um programa que insira vários números numa fila. Após a digitação dos números, seu programa deve encontrar o maior, o menor e a média aritmética dos números da fila. Por fim, informe os resultados encontrados.

int[] fila = new int[5];
float[] resposta = new float[3]; // 0 = maior, 1 = menor, 2 = soma
int inicio = 0,
    fim = 0;

void Insere(int valor)
{
    fila[fim] = valor;
    fim = fim + 1;
}

int Remove()
{
    inicio = inicio + 1;
    return (fila[inicio - 1]);
}

bool EstaVazia()
{
    if (inicio == fim)
        return true;
    else
        return false;
}

bool EstaCheia()
{
    if (fim == 5)
        return true;
    else
        return false;
}

while (EstaCheia() == false)
{
    Console.Write("Digite um número: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Insere(num);
}

resposta[0] = fila[0];
resposta[1] = fila[0];
resposta[2] = 0;

while (EstaVazia() == false)
{
    int num = Remove();

    if (num > resposta[0])
        resposta[0] = num;
    if (num < resposta[1])
        resposta[1] = num;
    resposta[2] += num;
}

Console.WriteLine($"Maior: {resposta[0]}, Menor: {resposta[1]}, Média: {resposta[2] / 5}");
