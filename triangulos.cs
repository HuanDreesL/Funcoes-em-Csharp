//Faça um algoritmo que receba o tamanho dos
//três lados de um triângulo e faça as seguintes
//atividades: retornar se os três lados realmente
//formam um triângulo e que tipo de triângulo é
//este. Cada uma destas atividades deve ser
//uma função:

using System.Runtime.InteropServices;

bool Triangulo(int a, int b, int c)
{
    bool ehTriangulo;

    if (a > 0 && b > 0 && c > 0)
    {
        ehTriangulo = true;
    }
    else
    {
        ehTriangulo = false;
    }

    if (ehTriangulo)
    {
        Console.WriteLine("É um triangulo");
    }
    else
    {
        Console.WriteLine("Não é um triangulo");
    }

    return ehTriangulo;
}

String tipoTriangulo(int a, int b, int c)
{

    if (a == b && a == c && b == c)
    {
        return "Equilatero";
    }
    if (a == b || a == c || b == c)
    {
        return "Isoceles";
    }
    else
    {
        return "Escaleno";
    }

}

Console.WriteLine("Digite o lado 1: ");
int lado1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o lado 2: ");
int lado2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o lado 3: ");
int lado3 = int.Parse(Console.ReadLine());


bool formaTriangulo = Triangulo(lado1, lado2, lado3);
if (formaTriangulo)
{
    string tipo = tipoTriangulo(lado1, lado2, lado3);
    Console.WriteLine($"O triângulo é {tipo}");
}
