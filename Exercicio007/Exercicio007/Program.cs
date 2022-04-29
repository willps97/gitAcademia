using System.Globalization;
/*7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.*/

Console.WriteLine("Digite o número do vendedor: ");
int sellerId = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o salário fixo do vendedor: ");
double sellerFix = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Digite o total de vendas do vendedor: ");
double sells = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Digite o % de comissionamento do vendedor: ");
double commission = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double totalSalary = sellerFix + (sells * (commission / 100));

Console.WriteLine($"O vendedor {sellerId} receberá o total de: {totalSalary.ToString("F2",CultureInfo.InvariantCulture)}");





