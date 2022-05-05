/*3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.*/

Console.Write("Digite o primeiro número: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Digite o segundo número: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Digite o terceiro número: ");
double c = double.Parse(Console.ReadLine());
Console.Write("Digite o quarto número: ");
double d = double.Parse(Console.ReadLine());

double media = (a + b + c + d) / 4;

Console.WriteLine("A média é de: " + media );

if (media < a)
{
    Console.WriteLine($"{a} é maior do que a média.");
}

if (media < b)
{
    Console.WriteLine($"{b} é maior do que a média.");
}

if (media < c)
{
    Console.WriteLine($"{c} é maior do que a média.");
}

if (media < d)
{
    Console.WriteLine($"{d} é maior do que a média.");
}