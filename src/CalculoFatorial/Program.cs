int numero, resposta;

Console.Write("Informe um número: ");
numero = int.Parse(Console.ReadLine());

resposta = fatorial(numero);
Console.WriteLine($"O resultado do fatorial de {numero} é: {resposta}");

int fatorial(int valor)
{
    if (valor == 0)
    {
        return 1;
    }
    else
    {
        Console.WriteLine($"{valor}! = {valor} * {fatorial(valor - 1)} ");
        return (valor * fatorial(valor - 1));
    }
}
