/*6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
Ao final, mostre a idade digitada.*/

Console.Write("Digite a idade da pessoa: ");
int idade = int.Parse(Console.ReadLine());
while (idade < 0 )
{
    Console.WriteLine("Idade incorreta. Digite uma idade maior do que '0'.");
     idade = int.Parse(Console.ReadLine());
}
Console.WriteLine("A idade digitada foi de " + idade + " anos.");