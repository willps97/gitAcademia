/*2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
informar um outro número. Caso positivo, o programa em VS deve ser repetido.*/

Console.WriteLine("Digite um número inteiro positivo: ");
int num = int.Parse(Console.ReadLine());

while (num < 0)
{
    Console.WriteLine("Número negativo. Digite um número inteiro positivo!");
    num = int.Parse(Console.ReadLine());
}

for (int i = 0; i <= num; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
    }
}
Console.WriteLine();
Console.WriteLine("------------------------------------");
Console.Write("Deseja informar outro número? (s/n): ");
char conf = char.Parse(Console.ReadLine().ToLower());
while(conf != 'n')
{
    Console.WriteLine("Digite um número inteiro positivo: ");
     num = int.Parse(Console.ReadLine());

    while (num < 0)
    {
        Console.WriteLine("Número negativo. Digite um número inteiro positivo!");
        num = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i <= num; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + ", ");
        }
    }

    Console.WriteLine("Deseja informar outro número? (s/n): ");
     conf = char.Parse(Console.ReadLine().ToLower());
}