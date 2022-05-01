using System.Globalization;
/*11) Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. 
 * Calcule e escreva o percentual que cada um representa em relação ao total de eleitores.*/

Console.WriteLine("Digite o número de eleitores do município: ");
double eleitores = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Digite o número de votos em branco: ");
double votosBranco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Digite o número de votos nulos: ");
double votosNulos = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Digite o número de votos válidos: ");
double votosValidos = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double percentualValidos = (votosValidos / eleitores) * 100;

double percentualNulos = (votosNulos / eleitores) * 100;

double percentualBranco = (votosBranco / eleitores) * 100;

Console.WriteLine($"O percentual de votos válidos é de {percentualValidos.ToString("F2",CultureInfo.InvariantCulture)} %. ");
Console.WriteLine($"O percentual de votos em branco é de {percentualBranco.ToString("F2", CultureInfo.InvariantCulture)} %. ");
Console.WriteLine($"O percentual de votos em branco é de {percentualNulos.ToString("F2", CultureInfo.InvariantCulture)} %. ");