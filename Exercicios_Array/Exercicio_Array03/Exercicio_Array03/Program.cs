/*3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
Se o usuário digitar 0 o programa em VS deve parar. 
Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo. */


 
    Console.WriteLine("digite um número: ");
    int num = int.Parse(Console.ReadLine());
    bool primo = true;

    if (num % 2 == 0)
    {
        Console.WriteLine("Número par.");
    }
    else
    {
        Console.WriteLine("Número impar.");
    }
    if (num == 0 || num == 1)
    {
        Console.WriteLine("Número não é primo.");
    }
    else
    {
        for (int i = 2; i<= (num/ 2); i++)
        {
            if (num % i == 0)
            {
                primo = false;
                break;
            }
        }
        if (primo)
        {
            Console.WriteLine("Número Primo.");
        }
        else
        {
            Console.WriteLine("Número não é primo.");
        }
    }
    while (num != 0)
{
    Console.WriteLine("digite um número: (Digite 0 para encerrar o programa.)");
     num = int.Parse(Console.ReadLine());
     primo = true;

    if (num % 2 == 0)
    {
        Console.WriteLine("Número par.");
    }
    else
    {
        Console.WriteLine("Número impar.");
    }
    if (num == 0 || num == 1)
    {
        Console.WriteLine("Número não é primo.");
    }
    else
    {
        for (int i = 2; i <= (num / 2); i++)
        {
            if (num % i == 0)
            {
                primo = false;
                break;
            }
        }
        if (primo)
        {
            Console.WriteLine("Número Primo.");
        }
        else
        {
            Console.WriteLine("Número não é primo.");
        }
    }
}




