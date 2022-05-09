/*8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
total de vendas. */

Console.Write("Digite o código do funcionário: ");
string id = Console.ReadLine();
Console.Write("Digite o nome do funcionário: ");
string nome = Console.ReadLine();
Console.Write("Digite o salário base do funcionário funcionário: ");
double salarioBase = double.Parse(Console.ReadLine());
Console.Write("Digite o total de vendas funcionário funcionário: ");
double vendas = double.Parse(Console.ReadLine()); 

if(vendas > 500.0)
{
    salarioBase = salarioBase + (vendas *0.05);
    Console.WriteLine($"O salário final do {nome} é de {salarioBase.ToString("F2")}");
}
else if (vendas > 1000.0)
{
    salarioBase = salarioBase + (vendas * 0.07);
    Console.WriteLine($"O salário final do {nome} é de {salarioBase.ToString("F2")}");
}
else if(vendas > 5000.0)
{
    salarioBase = salarioBase + (vendas * 0.10);
    Console.WriteLine($"O salário final do {nome} é de {salarioBase.ToString("F2")}");
}
   

