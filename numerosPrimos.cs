bool verificarPrimo(int a)
{
    bool verificado = true;

    if (a != 2 && a != 3)
    {
        for (int i = 2; i < a; i++)
        {
            if (a % i == 0)
            {
                verificado = false;
            }
        }
    }
    return verificado;
}
int somarPrimos(int a)
{
    int soma = 0;
    for (int i = 1; i < a; i++)
    {
        if (verificarPrimo(i)){
            soma += i;
        }

    }
    return soma;
}


Console.WriteLine("Insira o Valor: ");
int valor = int.Parse(Console.ReadLine());

bool verificarValor = verificarPrimo(valor);
Console.WriteLine(verificarValor);

int somarValoresPrimos = somarPrimos(valor);
Console.WriteLine(somarValoresPrimos);

