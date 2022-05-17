//Desenvolver um algoritmo que leia a cotação do euro converta para o Real, calcule a compra de 750 euros e imprima o resultado;

Console.WriteLine("Digite a cotação do euro:");
double cotacao = double.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor em euros:");
double euro = double.Parse(Console.ReadLine());

int euroFixo = 750;

double real = euro * cotacao;
double realFixo = euroFixo * cotacao;

Console.WriteLine($"{euro:n} euros valem {real:n} reais");
Console.WriteLine($"{euroFixo:n} euros valem {realFixo:n} reais");

