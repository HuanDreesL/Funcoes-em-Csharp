int CalcularPotencia(int valor, int expoente )
{
    int resultado = 1;
    for (int i = 0; i < expoente; i++)
    {
        resultado *= valor;
    }
    return resultado;
}


Console.WriteLine("Digite o numero: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o expoente: ");
int expoente = int.Parse(Console.ReadLine());

Console.WriteLine($"o resultado é {CalcularPotencia(numero, expoente)}");
