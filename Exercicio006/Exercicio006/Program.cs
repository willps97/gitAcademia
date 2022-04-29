/*6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
de IPI (única) a ser acrescentada. */

Console.WriteLine("Digite o código do parafuso A: ");
int codA = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade do parafuso A: ");
int qtdA = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a % de IPI do parafuso A");
int ipiA = int.Parse(Console.ReadLine());
Console.WriteLine("___________________________________");
Console.WriteLine("Digite o código do parafuso B: ");
int codB = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade do parafuso B: ");
int qtdB = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a % de IPI do parafuso B");
int ipiB = int.Parse(Console.ReadLine());

Console.WriteLine($"Dados parafuso A: Código = {codA}, Quantidade = {qtdA}, IPI = {ipiA}%");
Console.WriteLine($"Dados parafuso A: Código = {codB}, Quantidade = {qtdB}, IPI = {ipiB}%");


