/*1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido
pelo usuário.*/

Console.WriteLine("Digite um número inteiro positivo: ");
int num = int.Parse(Console.ReadLine());

while(num < 0)
{
    Console.WriteLine("Número negativo. Digite um número inteiro positivo!");
    num = int.Parse(Console.ReadLine());
}

for (int i = 0; i <= num; i++) 
{
    if(i % 2 == 0)
    {
        Console.Write(i + ", ");
    }
}