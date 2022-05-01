using System.Globalization;
/*12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. 
 *Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a  marcação do odômetro (marcador de quilometragem) no início do dia,
 *a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido dos passageiros.
 *Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

Média do consumo = Total quilometragem/ quantidade de combustível gasto

Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)*/

Console.WriteLine("Digite a marcação do começo do dia do odômetro: ");
double odometroInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Digite a marcação do fim do dia do odômetro: ");
double odometroFinal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Digite quantos litros de combustível foram gastos durante o dia :");
double consumoCombustivel = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Digite o valor recebido pelo dia de trabalho somando todos os passageiros: ");
double ganhosBrutos = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double consumoMedio = (odometroFinal - odometroInicial) / consumoCombustivel;
double lucroDia = ganhosBrutos - (consumoCombustivel * 6.90);

Console.WriteLine($"A média de consumo de combustível foi de {consumoMedio.ToString("F2",CultureInfo.InvariantCulture)} km/l e o lucro liquido foi de R$ {lucroDia.ToString("F2",CultureInfo.InvariantCulture)} ");
