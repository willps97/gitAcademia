/*18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.*/
Console.Write("Digite o primeiro valor: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Digite o terceiro valor: ");
int c = int.Parse(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine("O primeiro número é o maior!");
}
else if (b > a && b > c)
{
    Console.WriteLine("O segundo número é o maior!");
}
else
{
    Console.WriteLine("O terceiro numero é o maior!");
}