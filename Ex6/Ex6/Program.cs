// Desenvolver um algoritmo que leia a altura de um homem e calcule o seu peso ideal,
// utilize a seguinte fórmula: PESO IDEAL = (72.7 * H) – 58, onde H = altura.

Console.WriteLine("Digite a altura em metros:");
double H = double.Parse(Console.ReadLine());

if(H > 0)
{
    double pesoIdeal = (72.7 * H) - 58;
    if (pesoIdeal <= 0)
    {
        Console.Write("Valor de entrada inválido.");
    }
    else 
    {
        Console.WriteLine($"O peso ideal é {pesoIdeal} kg."); 
    }
    

}

else
{
    Console.WriteLine("Valor de altura inválido.");
}