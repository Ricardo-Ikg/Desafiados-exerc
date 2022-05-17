//Desenvolver um algoritmo que leia a altura de um homem e calcule o seu peso ideal
//fórmula: PESO IDEAL = (72.7 * H) – 58, onde H = altura.

Console.WriteLine("Digite a altura em metros:");
double H = double.Parse(Console.ReadLine());
double pesoIdeal = (72.7 * H) - 58;
if (pesoIdeal <= 0)
{
    Console.WriteLine("Valor inválido!");
}

else
{
    Console.WriteLine($"O peso ideal é:{pesoIdeal} kg");
}




