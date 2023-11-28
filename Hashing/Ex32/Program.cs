// Implemente um programa com as seguintes opções: Sem tratamento de colisão, Tratamento de colisão Linear e Tratamento de colisão com Lista Encadeada.
// Dentro de cada opção deve haver as funcionalidades: Inserir, Alterar e Relatar.
// O vetor deve ser do tipo abstrato de dado composto por idade, nome e whats. Serão necessários 3 vetores, um para cada tipo de tratamento de colisão.
// Para inserir um novo registro, solicite a idade, nome e whats. Utilize a idade como chave.
// Para alterar solicite a idade (chave) para ser utilizada na busca. Caso encontrada, informe o nome e o whats da pessoa. Após a consulta, o usuário pode atualizar somente o nome e o whats.
// Para relatar, percorra o vetor do inicio ao fim e exiba todos os registros.

Registro[] vetorSemColisao = new Registro[5];
Registro[] vetorLinear = new Registro[5];
ListaEncadeada[] vetorListaEncadeada = new ListaEncadeada[5];

int Hash(int chave)
{
    return chave % 5;
}

void InsereSemColisao(int chave)
{
    int pos = Hash(chave);

    Console.Write("Informe o nome: ");
    string nome = Console.ReadLine();
    Console.Write("Informe o whats: ");
    string whats = Console.ReadLine();

    Registro registro = new Registro();
    registro.idade = chave;
    registro.nome = nome;
    registro.whats = whats;

    vetorSemColisao[pos] = registro;

    Console.WriteLine("Registro inserido com sucesso.");
}

void InsereLinear(int chave)
{
    int pos = Hash(chave);

    while (vetorLinear[pos] != null)
    {
        pos = (pos + 1) % 5;
    }

    Console.Write("Informe o nome: ");
    string nome = Console.ReadLine();
    Console.Write("Informe o whats: ");
    string whats = Console.ReadLine();

    Registro registro = new Registro();
    registro.idade = chave;
    registro.nome = nome;
    registro.whats = whats;

    vetorLinear[pos] = registro;

    Console.WriteLine("Registro inserido com sucesso.");
}

void InsereListaEncadeada(int chave)
{
    int pos = Hash(chave);

    Console.Write("Informe o nome: ");
    string nome = Console.ReadLine();
    Console.Write("Informe o whats: ");
    string whats = Console.ReadLine();

    Registro registro = new Registro();
    registro.idade = chave;
    registro.nome = nome;
    registro.whats = whats;

    if (vetorListaEncadeada[pos] == null)
    {
        vetorListaEncadeada[pos] = new ListaEncadeada { Dado = registro, Proximo = null };
    }
    else
    {
        ListaEncadeada atual = vetorListaEncadeada[pos];
        while (atual.Proximo != null)
        {
            atual = atual.Proximo;
        }
        atual.Proximo = new ListaEncadeada { Dado = registro, Proximo = null };
    }

    Console.WriteLine("Registro inserido com sucesso.");
}

int BuscaLinear(int chave)
{
    int pos = Hash(chave);

    while (vetorLinear[pos] != null)
    {
        if (vetorLinear[pos].idade == chave)
            return pos;

        pos = (pos + 1) % 5;
    }

    return -1;
}

void AlteraLinear(int chave)
{
    int pos = BuscaLinear(chave);
    if (pos != -1)
    {
        Console.WriteLine($"Nome: {vetorLinear[pos].nome}, Whats: {vetorLinear[pos].whats}");
        Console.WriteLine("Informe o novo nome: ");
        vetorLinear[pos].nome = Console.ReadLine();
        Console.WriteLine("Informe o novo whats: ");
        vetorLinear[pos].whats = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Chave não encontrada.");
    }
}

void AlteraListaEncadeada(int chave)
{
    int pos = Hash(chave);

    ListaEncadeada atual = vetorListaEncadeada[pos];

    while (atual != null)
    {
        if (atual.Dado.idade == chave)
        {
            Console.WriteLine($"Nome: {atual.Dado.nome}, Whats: {atual.Dado.whats}");
            Console.WriteLine("Informe o novo nome: ");
            atual.Dado.nome = Console.ReadLine();
            Console.WriteLine("Informe o novo whats: ");
            atual.Dado.whats = Console.ReadLine();
            return;
        }

        atual = atual.Proximo;
    }

    Console.WriteLine("Chave não encontrada.");
}

void RelataLinear()
{
    Console.WriteLine(" ");

    for (int i = 0; i < vetorLinear.Length; i++)
    {
        if (vetorLinear[i] != null)
        {
            Console.WriteLine($"Posição {i}: Idade: {vetorLinear[i].idade}, Nome: {vetorLinear[i].nome}, Whats: {vetorLinear[i].whats}");
        }
        else
        {
            Console.WriteLine($"Posição {i}: Vazio");
        }
    }
}

void RelataSemColisao()
{
    Console.WriteLine(" ");

    for (int i = 0; i < vetorSemColisao.Length; i++)
    {
        if (vetorSemColisao[i] != null)
        {
            Console.WriteLine($"Posição {i}: Idade: {vetorSemColisao[i].idade}, Nome: {vetorSemColisao[i].nome}, Whats: {vetorSemColisao[i].whats}");
        }
        else
        {
            Console.WriteLine($"Posição {i}: Vazio");
        }
    }
}

void RelataListaEncadeada()
{
    Console.WriteLine(" ");

    for (int i = 0; i < vetorListaEncadeada.Length; i++)
    {
        Console.WriteLine($"Posição {i}:");
        ListaEncadeada atual = vetorListaEncadeada[i];
        while (atual != null)
        {
            Console.WriteLine($"  Idade: {atual.Dado.idade}, Nome: {atual.Dado.nome}, Whats: {atual.Dado.whats}");
            atual = atual.Proximo;
        }
    }
}

int opcao = 0, operacao = 0, idade = 0;

do
{
    Console.WriteLine("\n1 - Sem tratamento de colisão\n2 - Tratamento de colisão Linear\n3 - Tratamento de colisão com Lista Encadeada\n4 - Sair");
    Console.Write("Escolha a opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    if (opcao == 1 || opcao == 2 || opcao == 3)
    {
        Console.WriteLine("\n1 - Inserir\n2 - Alterar\n3 - Relatar\n0 - Voltar");
        Console.Write("Escolha a opção: ");
        operacao = Convert.ToInt32(Console.ReadLine());

        if (operacao == 1 || operacao == 2)
        {
            Console.Write("\nInforme a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
        }
    }

    switch (opcao)
    {
        case 1:
            switch (operacao)
            {
                case 1:
                    InsereSemColisao(idade);
                    break;
                case 2:
                    AlteraLinear(idade);
                    break;
                case 3:
                    RelataSemColisao();
                    break;
            }
            break;
        case 2:
            switch (operacao)
            {
                case 1:
                    InsereLinear(idade);
                    break;
                case 2:
                    AlteraLinear(idade);
                    break;
                case 3:
                    RelataLinear();
                    break;
            }
            break;
        case 3:
            switch (operacao)
            {
                case 1:
                    InsereListaEncadeada(idade);
                    break;
                case 2:
                    AlteraListaEncadeada(idade);
                    break;
                case 3:
                    RelataListaEncadeada();
                    break;
            }
            break;
        case 4:
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
} while (opcao != 4);

class Registro
{
    public int idade;
    public string nome;
    public string whats;
}

class ListaEncadeada
{
    public Registro Dado;
    public ListaEncadeada Proximo;
}