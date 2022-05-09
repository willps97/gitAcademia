/*17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo.
 * Para que os lados formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. 
 * Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos os lados iguais), 
 * isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).*/

Console.WriteLine("Digite o tamanho do lado A do triângulo: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o tamanho do lado B do triângulo: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o tamanho do lado C do triângulo: ");
int c = int.Parse(Console.ReadLine());

if(a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("Os lados formam um triângulo.");
    if(a == b && a == c)
    {
        Console.WriteLine("Triângulo equilátero");
    }
    else if(a == b || a == c || b == c)
    {
        Console.WriteLine("Triângulo Isóceles");
    }
    else
    {
        Console.WriteLine("Triângulo Escaleno.");
    }
}
else
{
    Console.WriteLine("Os lados não formam um triângulo!");
}