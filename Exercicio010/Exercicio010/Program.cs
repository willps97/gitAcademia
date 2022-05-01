using System.Globalization;

/*10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
notas de menor valor fossem distribuídas em número mínimo possível. 
Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, 
três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
de acordo com o critério da “distribuição ótima”.*/

int cem, cinquenta, vinte, dez, cinco, dois, um, resto, N;
N = int.Parse(Console.ReadLine());

cem = N / 100;
resto = N % 100;
cinquenta = resto / 50;
vinte = ((resto % 50) / 20);
dez = (((resto % 50) % 20) / 10);
cinco = ((((resto % 50) % 20) % 10) / 5);
dois = (((((resto % 50) % 20) % 10) % 5) / 2);
um = ((((((resto % 50) % 20) % 10) % 5) % 2) / 1);

Console.WriteLine(N);
Console.WriteLine(cem + " nota (s) de R$ 100,00");
Console.WriteLine(cinquenta + " nota (s) de R$ 50,00");
Console.WriteLine(vinte + " nota (s) de R$ 20,00");
Console.WriteLine(dez + " nota (s) de R$ 10,00");
Console.WriteLine(cinco + " nota (s) de R$ 5,00");
Console.WriteLine(dois + " nota (s) de R$ 2,00");
Console.WriteLine(um + " nota (s) de R$ 1,00");

