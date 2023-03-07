int numero, resposta;

Console.Write("Informe um número: ");
numero = int.Parse(Console.ReadLine());

resposta = Fatorial(numero);
Console.WriteLine($"O resultado do fatorial de {numero} é: {resposta}");

int Fatorial(int valor)
{
    if (valor == 0)
    {
        return 1;
    }
    else
    {
        int aux = valor - 1;
        Console.WriteLine($"{valor}! = {valor} * {aux}!");
        return  valor * Fatorial(aux);
    }
}
