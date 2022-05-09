using System.Globalization;

/*13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7 * h) - 58
Para mulheres: (62.1 * h) - 44.7*/

Console.Write("Entre com o sexo da pessoa. ('H-Homem | 'M-Mulher'): ");
char sexo = char.Parse(Console.ReadLine().ToUpper());

Console.Write("Digite a altura da pessoa ('Exemplo 1.80'): ");
double h = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

if(sexo == 'H')
{
    double pesoHomem = (72.7 * h) - 58;
    Console.WriteLine("O peso ideal deste homem é de: " + pesoHomem.ToString("F2",CultureInfo.InvariantCulture));
}
else if (sexo == 'M')
{
    double pesoMulher = (62.1 * h) - 44.7;
    Console.WriteLine("O peso ideal desta mulher é de: " + pesoMulher.ToString("F2", CultureInfo.InvariantCulture));
}