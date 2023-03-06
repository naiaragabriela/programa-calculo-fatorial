int anterior, numero, fatorial;

int BuscaNumero()
{
    Console.Write("Informe um número: ");
    return int.Parse(Console.ReadLine());
}

numero = BuscaNumero();
anterior = (numero - 1);
fatorial = 1;

void ResultadoFatorial()
{
    for (int i = numero; i>1; i--)
    {
        fatorial *= numero;
        Console.WriteLine($"{numero}! = {numero} * {anterior}!");
        numero = anterior;
        anterior = anterior - 1;

        if(numero == 1 || numero == 0)
        {
            Console.WriteLine($"{numero}! = 1");
        }
    }
    Console.WriteLine($"O resultado do fatorial é: {fatorial}");
}
ResultadoFatorial();