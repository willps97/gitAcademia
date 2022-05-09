using System.Globalization;

/*15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.*/

Console.Write("Digite a área a ser pintada 'em Metros quadradaos': ");
double area = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
double areaLitros = area / 3;
double latas = areaLitros / 18.0;
double preco = latas * 80.00;

if(areaLitros < 18)
{
    Console.WriteLine("A área a ser pintada necessita de menos de uma lata de tinta.");
}
else
{
    Console.WriteLine($"A área a ser pintada precisa de {latas.ToString("F0",CultureInfo.InvariantCulture)} latas de tinta. E o valor é de R$: {preco.ToString("F2",CultureInfo.InvariantCulture)}.");
}