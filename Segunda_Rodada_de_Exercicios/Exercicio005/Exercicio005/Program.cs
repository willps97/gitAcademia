using System.Globalization;

/*5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” se a média das duas notas for maior 
ou igual a 7,0. Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final. 
Se esta média for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve escrever “Reprovado”.*/

Console.Write("Digite a nota 001 do aluno: ");
double notaA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Digite a nota 002 do aluno: ");
double notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double media = (notaA + notaB) / 2;

if(media < 7.0)
{
    Console.Write($"A nota do aluno foi {media.ToString("F1",CultureInfo.InvariantCulture)}. Por favor digite a nota do exame: ");
    double exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    double mediaFinal = (notaA + notaB + exame) / 3;
    if(exame <= 5.0)
    {
        Console.WriteLine($"Nota: {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}. Aluno reprovado!");
    }
    else
    {
        Console.WriteLine($"Nota: {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}. Aluno Aprovado!");
    }
}
else
{
    Console.WriteLine($"Média: {media.ToString("F1",CultureInfo.InvariantCulture)}. Aluno Aprovado!");
}
