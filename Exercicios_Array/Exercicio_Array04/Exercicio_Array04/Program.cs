/*4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
de votos em branco. */

int joao = 0, zeca = 0, branco = 0;
string voto = "";

while(voto != "FIM")
{
    Console.WriteLine("VOTE no Joao/Zeca ou em Branco. Para finalizar digite FIM");
    Console.WriteLine("Digite o novo voto: ");
    voto = Console.ReadLine().ToUpper();

    if (voto == "JOAO")
    {
        joao += 1;
    }
    else if (voto == "ZECA")
    {
        zeca += 1;
    }
    else if (voto == "BRANCO")
    {
        branco += 1;
    }

}

Console.WriteLine($"{joao} votos em João; {zeca} votos em Zeca; {branco} votos em branco.");

