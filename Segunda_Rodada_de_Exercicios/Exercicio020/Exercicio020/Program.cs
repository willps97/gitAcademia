/*20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
plus: você pode gerar o número de forma randomica (função random c#).*/


Console.WriteLine("Digite um número entre 0 e 100 e tente adivinhar o número. Você terá 3 chances!");
int randomNum = int.Parse(Console.ReadLine());
Random numAleatorio = new Random();
int numSecreto = numAleatorio.Next(0,100);

for (int i = 1; i < 3; i++)
{
    if(numSecreto != randomNum)
    {
        Console.WriteLine($"Errou! você possui {3 - i} chances. Digite um novo número: ");
         randomNum = int.Parse(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Parabéns você acertou o número secreto! ");
        
    }
}
Console.WriteLine("Você perdeu o jogo. O número secreto era o: " + numSecreto);