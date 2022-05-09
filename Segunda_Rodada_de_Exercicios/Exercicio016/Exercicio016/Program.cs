/*16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
enfrentar novamente em um novo jogo.
ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.*/

Console.Write("Digite a quantidade de gols feita pelo time da casa (Time A): ");
int placarTimeA = int.Parse(Console.ReadLine());
Console.Write("Digite a quantidade de gols feita pelo time visitante (Time B): ");
int placarTimeB = int.Parse(Console.ReadLine());

int diferenca = placarTimeB - placarTimeA;

if(diferenca >= 2)
{
    Console.WriteLine("O time de fora já se classificou");
}
else
{
    Console.WriteLine("Houve jogo da volta!");
    Console.WriteLine();
    Console.Write("Digite a quantidade de gols feita pelo time da casa (TimeB): ");
    int placarTimeB2 =int.Parse (Console.ReadLine());
    Console.Write("Digite a quantidade de gols feita pelo time visitante (Time A): ");
    int placarTimeA2 = int.Parse(Console.ReadLine());

    int placarFinalA = placarTimeA + placarTimeA2;
    int placarFinalB = placarTimeB + placarTimeB2;

    if(placarFinalA > placarFinalB)
    {
        Console.WriteLine("O time A passou de fase.");
    }
    else
    {
        Console.WriteLine("O time B passou de fase.");
    }
}

