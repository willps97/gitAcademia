/*9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
o zoológico num determinado dia, imprimindo:
Quantas pessoas tem entre 1 e 3 filhos.
Quantas pessoas tem entre 4 e 7 filhos.
Quantas pessoas tem mais de 8 filhos.
Quantas pessoas não tem filhos.*/

int filhos1_3 = 0;
int filhos4_7 = 0;
int filhosMais_8 = 0;
int naoTemFilhos = 0;
int qtdFilhos = 0;

for(int i = 0; i < 30; i++)
{
    Console.WriteLine($"Digite a quantidade de filhos da pessoa {i + 1 } de 5");
    qtdFilhos = int.Parse(Console.ReadLine());

    if (qtdFilhos > 0 && qtdFilhos <= 3)
    {
        filhos1_3++;
    }
    else if (qtdFilhos >= 4 && qtdFilhos <= 7)
    {
        filhos4_7++;
    }
    else if (qtdFilhos >= 8)
    {
        filhosMais_8++;
    }
    else if (qtdFilhos == 0)
    {
        naoTemFilhos++;
    }

}

Console.WriteLine($"{naoTemFilhos} não possuem filhos");
Console.WriteLine($"{filhos1_3} possuem entre 1 e 3 filhos");
Console.WriteLine($"{filhos4_7} possuem entre 4 e 7 filhos");
Console.WriteLine($"{filhosMais_8} possuem mais de 8 filhos");



