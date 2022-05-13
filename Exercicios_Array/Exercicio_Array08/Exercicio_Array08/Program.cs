/*8. Faça um programa em VS que solicite um numero inteiro. S
e o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.*/


int numero = -1;
char validacao = 'S';

while(validacao != 'N')
{
    Console.WriteLine("Digite um número inteiro: ");
    numero = int.Parse(Console.ReadLine());
    if(numero % 2 == 0)
    {
        Console.WriteLine("Numero par.");
    }
    else
    {
        Console.WriteLine("Numero Impart");
    }

    Console.WriteLine("Deseja repetir o programa? (S/N): ");
    validacao = char.Parse(Console.ReadLine().ToUpper());
}

