/*10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
O programa deve mostrar os dados do atleta mais novo e mais alto.*/

Console.Write("Digite o nome do atleta 001: ");
string nomeA = Console.ReadLine();
Console.Write("Digite a idade do atleta 001: ");
int idadeA = int.Parse(Console.ReadLine());
Console.Write("Digite a altura do atleta 001: ");
double alturaA = double.Parse(Console.ReadLine());

Console.Write("Digite o nome do atleta 002: ");
string nomeB = Console.ReadLine();
Console.Write("Digite a idade do atleta 002: ");
int idadeB = int.Parse(Console.ReadLine());
Console.Write("Digite a altura do atleta 002: ");
double alturaB = double.Parse(Console.ReadLine());

if(idadeA < idadeB && alturaA > alturaB)
{
    Console.WriteLine($"Nome: {nomeA}; Altura: {alturaA}; idade: {idadeA} ");
}
else if(idadeA > idadeB && alturaA < alturaB)
{
    Console.WriteLine($"Nome: {nomeB}; Altura: {alturaB}; idade: {idadeB} ");
}
else
{
    Console.WriteLine("Os atletas possuem altura e idades dispares.");
}