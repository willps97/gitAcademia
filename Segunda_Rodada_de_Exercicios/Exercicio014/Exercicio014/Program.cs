using System.Globalization;
/*14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
do arquivo usando este link (em minutos).*/

Console.Write("Digite o tamanho do arquivo em MB: ");
double mbs = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Digite a valocidade da sua internet: ");
double velocidadeBanda = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double velocidadeTotal = (mbs / velocidadeBanda) / 60;

Console.WriteLine("O seu download será finalizado em " + velocidadeTotal.ToString("F2",CultureInfo.InvariantCulture) + " minutos.");

