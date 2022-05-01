using System.Globalization;

/*13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo.
 *Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o preço de custo de cada bicicleta vendida. 
 *Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
vendidas pelo vendedor, calcule e mostre: o salário do empregado*/

Console.WriteLine("Digite o salário mínimo:");
double salarioMinimo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Digite o preço de custo da bicicleta: ");
double precoDeCusto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Digite o número de bicicletas vendidas: ");
int bikesVendidas = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double salarioTotal = (salarioMinimo * 2) + (((precoDeCusto * 1.50) * 0.15) * bikesVendidas);

Console.WriteLine("O salário total do funcionário é de R$: " + salarioTotal.ToString("F2",CultureInfo.InvariantCulture));