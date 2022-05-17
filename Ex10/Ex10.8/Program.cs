// Desenvolver um algoritmo que leia dois valores, A e B, utilizar operador aritmético de subtração
//Imprimir o total
//Se o valor for negativo, imprimir TOTAL NEGATIVO senão TOTAL POSITIVO;

Console.WriteLine("Digite um valor para A:");
float a = float.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor para B:");
float b = float.Parse(Console.ReadLine());

float sub = a - b;

Console.WriteLine($"{a} - {b} = {sub}");

if (sub < 0)
{
    Console.WriteLine("Total NEGATVO!");
}

else
{
    Console.WriteLine("Total POSITIVO!");
}