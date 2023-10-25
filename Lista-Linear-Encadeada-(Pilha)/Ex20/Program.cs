// Faça um programa que utilize lista encadeada e que tenha as opções a seguir. O nó deve conter os atributos: nome, idade, whats e prox.

// a) Incluir conforme apresentado em aulas
// b) Para alterar, consulte pelo nome. Se encontrar, exiba os valores atuais e permita a alteração. Caso não encontre, exiba mensagem de não encontrado.
// c) Para excluir, procure pelo nome. Se encontrar, exiba os valores atuais e permita a exclusão. Caso não encontre, exiba mensagem de não encontrado.
// d) Na opção exibir, exiba todos os registros.

tp_pessoa lista = null;

void Insere(string nome, int idade, string whats)
{
    tp_pessoa novo = new tp_pessoa();
    novo.nome = nome;
    novo.idade = idade;
    novo.whats = whats;
    novo.prox = lista;
    lista = novo;

    Console.WriteLine("\nUsuário inserido com sucesso!");
}

void Remove(string nome)
{
    tp_pessoa aux = lista;
    tp_pessoa ant = null;

    while (aux != null)
    {
        if (aux.nome == nome)
        {
            if (ant == null)
            {
                lista = aux.prox;
            }
            else
            {
                ant.prox = aux.prox;
            }

            Console.WriteLine("\nUsuário removido com sucesso!");
            break;
        }

        ant = aux;
        aux = aux.prox;
    }

    if (aux == null)
    {
        Console.WriteLine("\nNome não encontrado!");
    }
}

void Altera(string nome)
{
    tp_pessoa aux = lista;
    while (aux != null)
    {
        if (aux.nome == nome)
        {
            Console.WriteLine("\nNome: " + aux.nome);
            Console.WriteLine("Idade: " + aux.idade);
            Console.WriteLine("Whats: " + aux.whats);
            Console.Write("\nInforme o novo nome: ");
            aux.nome = Console.ReadLine();
            Console.Write("Informe a nova idade: ");
            aux.idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o novo whats: ");
            aux.whats = Console.ReadLine();

            Console.WriteLine("\nUsuário alterado com sucesso!");
            break;
        }

        aux = aux.prox;
    }

    if (aux == null)
    {
        Console.WriteLine("\nNome não encontrado!");
    }
}

void Exibe()
{
    tp_pessoa aux = lista;

    while (aux != null)
    {
        Console.WriteLine("\nNome: " + aux.nome);
        Console.WriteLine("Idade: " + aux.idade);
        Console.WriteLine("Whats: " + aux.whats);
        aux = aux.prox;
    }

    if (lista == null)
    {
        Console.WriteLine("\nNenhum cadastro encontrado!");
    }
}

void Main()
{
    int opcao = 0;

    do
    {
        opcao = 0;

        Console.WriteLine(
            "\n=-=-=-=-= MENU =-=-=-=-=\n1 - Incluir\n2 - Alterar\n3 - Excluir\n4 - Exibir\n5 - Sair"
        );
        Console.Write("\nInsira a opção desejada: ");
        opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.Write("\nInforme o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Informe a idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Informe o Whats: ");
                string whats = Console.ReadLine();
                Insere(nome, idade, whats);
                break;
            case 2:
                Console.Write("\nInforme o nome: ");
                nome = Console.ReadLine();
                Altera(nome);
                break;
            case 3:
                Console.Write("\nInforme o nome: ");
                nome = Console.ReadLine();
                Remove(nome);
                break;
            case 4:
                Exibe();
                break;
            case 5:
                Console.Write("\nSaindo...");
                break;
            default:
                Console.WriteLine("\nOpção inválida!");
                break;
        }
    } while (opcao != 5);
}

Main();

class tp_pessoa
{
    public string nome,
        whats;
    public int idade;
    public tp_pessoa prox = null;
}
