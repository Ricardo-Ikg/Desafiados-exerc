Console.WriteLine("Digite um valor inteiro para A:");
int a =   int.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor inteiro para B:");
int b = int.Parse(Console.ReadLine());

if (b == 0)
{
    Console.Write("Erro!\nImpossível dividir por 0");
}

else
{
    int div = a / b;
    int resto = a % b;

    Console.WriteLine($"{a} / {b} = {div} com resto {resto}");
}