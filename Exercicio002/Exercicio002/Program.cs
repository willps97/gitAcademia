/*2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética 
 * entre quatro números quaisquer.*/

Console.WriteLine("Digite o primeiro número");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o Segundo número");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número");
double c = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o quarto número");
double d = double.Parse(Console.ReadLine());

double media = (a + b + c + d) / 4;

Console.WriteLine("A média dos 4 números é de: " + media);