// Faça uma implementação que construa uma lista encadeada. Seu programa deve inserir vários valores na lista e em seguida removê-los. Após remover um elemento da lista, exiba-o na tela.

tp_no topo = null;

void Insere(int valor)
{
    tp_no no = new tp_no();
    no.valor = valor;
    no.prox = topo;

    topo = no;
}

tp_no Remove()
{
    tp_no no = topo;
    if (topo != null)
        topo = topo.prox;

    return no;
}

for (int i = 0; i < 5; i++)
{
    Console.Write("Informe um valor: ");
    Insere(Convert.ToInt32(Console.ReadLine()));
}

Console.WriteLine("\nValores removidos da lista:");

while (topo != null)
    Console.WriteLine(Remove().valor);

class tp_no
{
    public int valor = 0;
    public tp_no prox = null;
}
