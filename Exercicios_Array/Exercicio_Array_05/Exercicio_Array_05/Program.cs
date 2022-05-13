/*5. Modifique o programa em VS anterior para aceitar votos nulos 
(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
Ao final, informe o nome do candidato vencedor, o número de votos nulos e o número de pessoas que votaram.*/


int joao = 0, zeca = 0, branco = 0, nulo = 0;
string voto = "";

Console.WriteLine("VOTE no Joao/Zeca/Branco ou Nulo. Para finalizar digite 'FIM'.");
while (voto != "FIM")
{
    
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
    else if (voto == "NULO")
    {
        nulo += 1;
    }
}

Console.WriteLine($"{joao} votos em João; {zeca} votos em Zeca; {branco} votos em branco; {nulo} votos nulos.");
if(joao > zeca && joao > branco && joao > nulo)
{
    Console.WriteLine("João foi o vencedor.");
}
else if (zeca > joao && zeca > nulo && zeca > branco)
{
    Console.WriteLine("Zeca foi o vencedor.");
}
else if (branco > nulo && branco > joao && branco > zeca)
{
    Console.WriteLine("Votos em branco foram maioria");
}
else
{
    Console.WriteLine("Votos em nulo foram maioria");
}