int i = 0;
double soma = 0; 

while (i < 4)
{
    Console.WriteLine("Digite a nota do aluno");
    double nota  = Double.Parse(Console.ReadLine());
    soma = nota + soma;
    i++;

}

double media = soma / i;

Console.WriteLine($"A média do aluno é {media}");

if (media > 7)
{
    Console.WriteLine("Média maior do que 7, aluno aprovado!");

}

else
{
    Console.WriteLine("Média insuficiente, aluno reprovado!");
}