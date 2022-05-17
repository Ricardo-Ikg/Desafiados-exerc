Console.WriteLine("Digite o valor de A:");
float a = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de B:");
float b = float.Parse(Console.ReadLine());

float sub = a - b;

Console.WriteLine($"O valor da subtração de A - B é: {sub}");

if (sub < 0)
{
    Console.WriteLine("O valor da subtração é NEGATIVO!");
}

else
{
    Console.WriteLine("O valor da substração é POSITIVO!");
}


