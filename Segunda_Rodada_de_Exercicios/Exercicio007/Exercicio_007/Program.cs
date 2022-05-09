/*7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.*/

Console.Write("Olá! Digite uma frase: ");
string frase = Console.ReadLine();
string[] vet = frase.Split(" ");

Console.Write("Digite uma palavra para verificar se existe na frase: ");
string palavra = Console.ReadLine();

for(int i = 0; i < vet.Length; i++)
{
    if(vet[i] == palavra)
    {
        Console.WriteLine("A palavra encontra -se na palavra");
    }
    else
    {
        Console.WriteLine("A palavra não encontra -se na palavra");
    }
}
