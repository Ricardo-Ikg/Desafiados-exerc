//Desenvolver um algoritmo para converter a temperatura em graus Fahrenheit para Celsius
//fórmula C = (F -32) *5 / 9;

Console.WriteLine("Insira a temperatura em Fahrenheit:");
double F = double.Parse(Console.ReadLine());

double C = (F - 32) * 5 / 9;

Console.WriteLine($"A temperatura em graus Celsius é {C}ºC.");