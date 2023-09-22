// Faça um programa que apresente um menu inicial com as seguintes opções:

// MENU PRINCIPAL

// 1 – Funções sem vetor
// 2 – Função com vetor
// 3 - Sair

// Digite a opção desejada:

// Se o usuário escolher a opção 1, solicite um número inteiro inicial e um número inteiro final. O número final deve ser maior que o inicial. Em seguida apresente um segundo menu com as seguintes opções:

// MENU SECUNDÁRIO

// 1 - Inteiros em ordem crescente
// 2 - Inteiros em ordem decrescente
// 3 - Inteiros ímpares (crescente)
// 4 - Somatório dos inteiros

// Faça uma função recursiva para cada opção desse segundo menu.

// Se o usuário escolher a opção 2 (do menu inicial), solicite vários números inteiros (armazene num vetor) e em seguida faça uma função recursiva que calcule o somatório dos números do vetor.

void crescente(int nI, int nF)
{
    if (nI <= nF)
    {
        Console.WriteLine(nI);
        nI += 1;
        crescente(nI, nF);
    }
}

void decrescente(int nI, int nF)
{
    if (nI <= nF)
    {
        decrescente(nI + 1, nF);
        Console.WriteLine(nI);
    }
}

void Impares(int nI, int nF)
{
    if (nI <= nF)
    {
        if (nI % 2 != 0)
            Console.WriteLine(nI);
        nI += 1;
        Impares(nI, nF);
    }
}

int somatorio(int nI, int nF)
{
    if (nI < nF)
        return somatorio(nI + 1, nF) + nI;
    else
        return nI;
}

int somaVetor(int[] v, int iI, int iF)
{
    if (iI < iF)
        return somaVetor(v, iI + 1, iF) + v[iI];
    else
        return v[iI];
}

string op = "0";
while (op != "3")
{
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Funções sem vetor");
    Console.WriteLine("2 - Função com vetor");
    Console.WriteLine("3 - Sair");
    Console.Write("Opção desejada: ");
    op = Console.ReadLine();
    if (op == "1")
    {
        Console.WriteLine("Digite número inicial: ");
        int nI = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite número final: ");
        int nF = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("MENU SECUNDÁRIO");
        Console.WriteLine("1 - Inteiros em ordem crescente");
        Console.WriteLine("2 - Inteiros em ordem decrescente");
        Console.WriteLine("3 - Inteiros Ímpares (crescente)");
        Console.WriteLine("4 - Somatório dos inteiros");
        Console.WriteLine("5 - Voltar");
        Console.Write("Opção desejada: ");
        string op2 = Console.ReadLine();
        if (op2 == "1")
            crescente(nI, nF);
        else if (op2 == "2")
            decrescente(nI, nF);
        else if (op2 == "3")
            Impares(nI, nF);
        else if (op2 == "4")
        {
            int s = somatorio(nI, nF);
            Console.WriteLine("A soma é: " + s);
        }
    }
    else if (op == "2")
    {
        int[] vetor = new int[10];
        int n = 1,
            i = 0;
        while (n != 0)
        {
            Console.WriteLine("Dig No: ");
            n = Convert.ToInt32(Console.ReadLine());
            vetor[i] = n;
            i = i + 1;
        }
        int s = somaVetor(vetor, 0, i);
        Console.WriteLine("A soma é: " + s);
    }
}
