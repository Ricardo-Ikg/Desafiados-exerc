//Desenvolver um algoritmo para converter a temperatura em graus Fahrenheit para Celsius, a fórmula é C = (F -32) *5 / 9;

Console.WriteLine("Digite o valor da temperatura em Fahrenheit");
double F = double.Parse(Console.ReadLine());

double C = (F - 32) * 5 / 9;

if (F >= -459.67)
{
    Console.WriteLine($"A temperatura em graus Celsius é {C}ºC");
}

else
{
    Console.WriteLine("Entrada inválida.\nTemperatura abaixo do zero absoluto.");
}