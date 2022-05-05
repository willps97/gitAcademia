/*2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. */

Console.Write("Digite um número: ");
int n = int.Parse(Console.ReadLine());

if(n % 2 == 0)
{
    Console.WriteLine($"{n} é par");
}
else
{
    Console.WriteLine($"{n} é impar");
}