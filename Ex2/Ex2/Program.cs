//Desenvolver um algoritmo que leia a cotação do euro converta para o Real
//calcule a compra de 750 euros e imprima o resultado;

Console.WriteLine("Insira a cotação do euro.");
double cotacao = double.Parse(Console.ReadLine());

double euro = 750;
double real = cotacao * euro;

Console.WriteLine($"{euro} valem {real} reais.");