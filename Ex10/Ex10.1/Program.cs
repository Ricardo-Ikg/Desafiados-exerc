//Desenvolver um algoritmo que calcule a idade média dos alunos de uma classe da faculdade
//utilize a seguinte fórmulapara calcular: MEDIA ALUNO = (IDADE MÍNIMA + IDADE MÁXIMA) / 2;

Console.WriteLine("Digite a idade do aluno mais novo:");
int idadeMinima = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a idade do aluno mais velho:");
int idadeMaxima = int.Parse(Console.ReadLine());

double media = (idadeMinima + idadeMaxima) / 2;

Console.WriteLine($"A idade média dos alunos é {media} anos.");