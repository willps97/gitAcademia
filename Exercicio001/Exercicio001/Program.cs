/*1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética
 * entre dois números quaisquer.*/

Console.WriteLine("Digite um número: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Digite outro  número: ");
double b = double.Parse(Console.ReadLine());

double divisao = a / b;

Console.WriteLine($"A divisão de {a} por {b} é de {divisao}");
