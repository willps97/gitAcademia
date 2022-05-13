﻿/*7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
A cada solicitação, teste se o usuário informou um valor válido. 
Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
informe que ele está incorreto e saia do programa em VS. 
Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
informe que está errada e saia. Se estiver correta, solicite o salário. 
Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
Se estiver correto, mostre todos os valores lidos.*/


while (true)
{
    Console.WriteLine("Digite o nome do funcionário: ");
    string nome = Console.ReadLine();
    if (nome == "")
    {
        Console.WriteLine("Dado invalido!");
        break;
    }
    Console.WriteLine("Digite a idade do funcionário: ");
    int idade = int.Parse(Console.ReadLine());
    if(idade < 0)
    {
        Console.WriteLine("Dado invalido!");
        break;
    }
    Console.WriteLine("Digite o salário do funcionário: ");
    double salario = double.Parse(Console.ReadLine());
    if(salario <= 0)
    {
        Console.WriteLine("Dado invalido!");
        break;
    }

    Console.WriteLine($"Nome: {nome}; Idade: {idade}; Salário: {salario}");

    break;
}

