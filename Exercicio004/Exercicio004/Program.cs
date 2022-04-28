/*4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.*/

Console.Write("Digite o dia 'DD' ");
int dia = int.Parse(Console.ReadLine());

Console.Write("Digite o mês 'MM' ");
int mes = int.Parse(Console.ReadLine());

Console.Write("Digite o ano 'AAAA' ");
int ano = int.Parse(Console.ReadLine());

Console.WriteLine($"Ano/Mês/dia = {ano}/{mes}/{dia}");
