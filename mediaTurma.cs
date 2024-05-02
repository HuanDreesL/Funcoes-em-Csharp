/*
Faça um algoritmo que calcule a média
aritmética de todas as turmas de uma escola.
Considere como entradas o número de turmas
e o número de alunos de cada turma. A média
aritmética de cada turma deve ser
apresentada, além da média geral, que será o
resultado da média das turmas. O algoritmo
deverá ter as funções ‘MediaTurma’ e
‘MediaEscola”. O usuário entrará, dentro da
função principal, com a quantidade de turmas
e, dentro da função ‘MediaEscola’
, com o
número de alunos de cada turma.
*/
double mediaTurma(int NumeroAlunos)
{
    double mediaDaTurma = 0;
    double notas = 0;
    double somaNotas = 0;

    for (int i = 1; i <= NumeroAlunos; i++)
    {

        Console.WriteLine($"Digite a nota do Aluno {i}: ");
        notas = double.Parse(Console.ReadLine() );
        somaNotas = somaNotas + notas;

    }
    
    mediaDaTurma = somaNotas / NumeroAlunos;

    return mediaDaTurma;
}
double mediaEscola(int NumeroTurmas)
{
    double mediaDaEscola = 0;
    double somaMediaEscola = 0;
    int qtdAluno = 0;

    for (int i = 1; i <= NumeroTurmas; i++)
    {
        Console.WriteLine("Digite o Número de Alunos por Turma: ");
        qtdAluno = int.Parse(Console.ReadLine());
        double mediaTurmaAtual = mediaTurma(qtdAluno);
        somaMediaEscola += mediaTurmaAtual;
    }
   
 
    mediaDaEscola = somaMediaEscola / NumeroTurmas;
    
    return mediaDaEscola;

}

Console.WriteLine("Digite o Número de Turmas: ");
int qtdTurma = int.Parse(Console.ReadLine());

double escolaMedia = mediaEscola(qtdTurma);
Console.WriteLine($"A média da escola é {escolaMedia}");

