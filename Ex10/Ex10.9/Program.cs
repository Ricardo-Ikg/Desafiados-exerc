//Desenvolver um algoritmo que leia dois valores, A e B, utilizar operador aritmético de divisão e
//modularização, ou seja, imprimir apenas o resto da divisão
//Tratar divisão por 0.

Console.WriteLine("Digite o dividendo.");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um divisor.");
int b = int.Parse(Console.ReadLine());

if (b == 0)
{
    Console.WriteLine("Erro!\nImpossível dividir por 0.");
}

else
{
    int div = a / b;
    int resto = a % b;

    Console.WriteLine($"{a} / {b} = {div} com resto {resto}");

}

