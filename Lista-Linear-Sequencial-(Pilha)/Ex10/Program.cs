// Escreva um programa para conhecer uma frase e exibi-la com as palavras invertidas sem inverter a frase. Por exemplo, a frase “Eu faço ADS” deve sair “uE oçaf SDA”.

char[] pilha = new char[20];
int topo = 0;

void Insere(char valor)
{
    pilha[topo] = valor;
    topo = topo + 1;
}

char Remove()
{
    topo = topo - 1;
    return (pilha[topo]);
}

bool EstaVazia()
{
    if (topo == 0)
        return true;
    else
        return false;
}

// bool EstaCheia()
// {
//     if (topo == 20)
//         return true;
//     else
//         return false;
// }

Console.Write("Insira uma frase: ");
string frase = Console.ReadLine();

int pos = 0;

for (int i = 0; i < frase.Length; i++)
{
    if (frase[i] == ' ' || i == frase.Length - 1)
    {
        int fimPalavra = i - 1;
        
        if (i == frase.Length - 1)
        {
            fimPalavra = i;
        }

        for (int j = pos; j <= fimPalavra; j++)
        {
            Insere(frase[j]);
        }

        pos = i + 1;

        while (EstaVazia() == false)
        {
            Console.Write(Remove());
        }

        Console.Write(" ");
    }
}
