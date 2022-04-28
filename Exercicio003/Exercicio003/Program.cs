/*Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
si os valores de duas variáveis A e B.*/

Console.WriteLine("Digite o número da variável A: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o número da variável B: ");
double b = double.Parse(Console.ReadLine());

double temp = 0.0;
double temp2 = 0.0;

temp = a;
temp2 = b;
b = temp;
a = temp2;


Console.WriteLine($"Os números A e B alterados são A = {a} e B = {b} ");