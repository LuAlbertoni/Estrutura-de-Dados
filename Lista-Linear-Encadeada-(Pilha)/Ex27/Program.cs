// Desenvolva um programa para inserir, pesquisar, remover e exibir os valores de uma árvore binária. Observe as opções a seguir:
// a) Inserir um valor digitado pelo usuário
// b) Pesquisar um valor digitado pelo usuário. Exiba uma mensagem informando se encontrou ou não
// c) Remover um valor digitado pelo usuário. Exiba a mensagem se removido com sucesso ou não encontrado
// d) Exibir todos os valores da árvore em ordem, pré ordem ou pós ordem

tp_no raiz = null;

char opcao;

do
{
    Console.WriteLine("\nMenu:\na) Inserir\nb) Pesquisar\nc) Remover\nd) Exibir\ne) Sair");

    Console.Write("Escolha uma opção: ");
    opcao = Convert.ToChar(Console.ReadLine().ToLower());

    switch (opcao)
    {
        case 'a':
            Console.Write("\nDigite o valor a ser inserido: ");
            int valorInserir = Convert.ToInt32(Console.ReadLine());
            Insere(ref raiz, valorInserir);
            break;

        case 'b':
            Console.Write("\nDigite o valor a ser pesquisado: ");
            int valorPesquisar = Convert.ToInt32(Console.ReadLine());

            tp_no noEncontrado = Busca(raiz, valorPesquisar);

            if (noEncontrado != null)
                Console.WriteLine("Valor encontrado!");
            else
                Console.WriteLine("Valor não encontrado.");
            break;

        case 'c':
            Console.Write("\nDigite o valor a ser removido: ");
            int valorRemover = Convert.ToInt32(Console.ReadLine());

            tp_no noRemovido = Remove(ref raiz, valorRemover);

            if (noRemovido != null)
                Console.WriteLine("Valor removido com sucesso!");
            else
                Console.WriteLine("Valor não encontrado para remoção.");
            break;

        case 'd':
            Console.WriteLine("\nEscolha a ordem de exibição:\n1) Em ordem\n2) Pré ordem\n3) Pós ordem");
            char ordem = Convert.ToChar(Console.ReadLine());

            switch (ordem)
            {
                case '1':
                    Console.WriteLine("\nExibindo em ordem:");
                    EmOrdem(raiz);
                    break;

                case '2':
                    Console.WriteLine("\nExibindo pré ordem:");
                    PreOrdem(raiz);
                    break;

                case '3':
                    Console.WriteLine("\nExibindo pós ordem:");
                    PosOrdem(raiz);
                    break;

                default:
                    Console.WriteLine("\nOpção inválida.");
                    break;
            }
            break;

        case 'e':
            break;

        default:
            Console.WriteLine("\nOpção inválida.");
            break;
    }

} while (opcao != 'e');


static void Insere(ref tp_no r, int x)
{
    if (r == null)
    {
        r = new tp_no();
        r.valor = x;
    }
    else if (x < r.valor)
        Insere(ref r.esq, x);
    else
        Insere(ref r.dir, x);
}

static tp_no Busca(tp_no r, int x)
{
    if (r == null)
        return null;
    else if (x == r.valor)
        return r;
    else if (x < r.valor)
        return Busca(r.esq, x);
    else
        return Busca(r.dir, x);
}

static tp_no RetornaMaior(ref tp_no r)
{
    if (r.dir == null)
    {
        tp_no p = r;
        r = r.esq;
        return p;
    }
    else
        return RetornaMaior(ref r.dir);
}

static tp_no Remove(ref tp_no r, int x)
{
    if (r == null)
        return null;
    else if (x == r.valor)
    {
        tp_no p = r;
        if (r.esq == null)
            r = r.dir;
        else if (r.dir == null)
            r = r.esq;
        else
        {
            p = RetornaMaior(ref r.esq);
            r.valor = p.valor;
        }
        return p;
    }
    else if (x < r.valor)
        return Remove(ref r.esq, x);
    else
        return Remove(ref r.dir, x);
}

static void EmOrdem(tp_no r)
{
    if (r != null)
    {
        EmOrdem(r.esq);
        Console.WriteLine(r.valor);
        EmOrdem(r.dir);
    }
}

static void PreOrdem(tp_no r)
{
    if (r != null)
    {
        Console.WriteLine(r.valor);
        PreOrdem(r.esq);
        PreOrdem(r.dir);
    }
}

static void PosOrdem(tp_no r)
{
    if (r != null)
    {
        PosOrdem(r.esq);
        PosOrdem(r.dir);
        Console.WriteLine(r.valor);
    }
}

class tp_no
{
    public tp_no esq = null;
    public int valor = 0;
    public tp_no dir = null;
}
