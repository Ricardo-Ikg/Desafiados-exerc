//Desenvolver um algoritmo que leia quatro notas de um aluno, calcular a média e imprimir
//Imprimir se o aluno foi aprovado ou reprovado
//Critério de aprovação Média > 7;

int i = 0;
double soma = 0;

while (i < 4)
{
    Console.WriteLine("Digite a nota do aluno:");
    double nota = double.Parse(Console.ReadLine());
    soma = soma + nota;
    i++;
}

double media = soma / i;

Console.WriteLine($"A media do aluno é {media}");

if (media > 7)
{
    Console.WriteLine("O aluno foi aprovado!");
}

else
{
    Console.WriteLine("O aluno foi reprovado.");
}