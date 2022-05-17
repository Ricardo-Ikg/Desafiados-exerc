//Desenvolver um algoritmo para converter a temperatura em graus Celsius para Fahrenheit, a fórmula é F = (9 * C + 160) / 5;

Console.WriteLine("Insira a temperatura em graus Celsius:");

double C = double.Parse(Console.ReadLine());
if(C >= -273.15)
{
    double F = (9 * C + 160) / 5;
    Console.WriteLine($"A temperatura em Fahrenheit é {F}ºF");
}

else
{
    Console.WriteLine("Entrada inválida.\nTemperatura abaixo do zero absoluto");
}
        

