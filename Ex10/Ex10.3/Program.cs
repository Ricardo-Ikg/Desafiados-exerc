//Desenvolver um algoritmo de comissão de vendas,
//ler o valor da comissão e das vendas e imprimir.

Console.WriteLine("Digite o valor total das vendas no mês:");
double vendas = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da porcentagem de comissão do vendedor:");
double porcentagem = double.Parse(Console.ReadLine());

double comissao = vendas * (porcentagem / 100);

Console.WriteLine($"O vendedor recebeu {comissao:n} reais de comissao esse mês.");