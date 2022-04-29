/*5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
(medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
consumido para percorrê-la (medido em l).*/


Console.WriteLine("Digite a kilometragem percorrida: ");
double km = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de combustivel consumida: ");
double combustivel = double.Parse(Console.ReadLine());

double consumo = km / combustivel;

Console.WriteLine($"O consumo médio e de: {consumo} km/l ");

