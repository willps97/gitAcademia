/*1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
 *Área do triangulo = (base * altura) / 2; 
Teste se a base ou a altura digitada não foi igual a zero.*/


Console.Write("Digite a base do triângulo:");
double largura = double.Parse(Console.ReadLine());
if (largura == 0)
{
    Console.WriteLine("a base não pode ser igual a zero.");
}
Console.Write("Digite a altura do triângulo:");
double altura = double.Parse(Console.ReadLine());
if (altura == 0)
{
    Console.WriteLine("a base não pode ser igual a zero.");
}

double triangulo = (largura * altura) / 2;

Console.WriteLine("A área do triângulo é de: " + triangulo);


