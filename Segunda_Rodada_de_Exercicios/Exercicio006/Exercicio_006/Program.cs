using System.Globalization;

/*6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
O cálculo do imc = peso / (altura * altura)

IMC 
menor que 18                -> baixo peso
maior que 18 e menor que 25 -> peso normal
maior que 25 e menor que 30 -> sobrepeso
maior que 30 e menor que 35 -> obesidade
maior que 35                -> obesidade grau sério*/

Console.Write("Digite o nome do paciente: ");
string nome = Console.ReadLine().ToUpper();

Console.Write("Digite a altura do paciente: ");
double altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.Write("Digite o peso do paciente: ");
double peso = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double imc = peso / Math.Pow(altura, 2);

if(imc < 18)
{
    Console.WriteLine($"O {nome} está com baixo peso. Seu IMC é de: {imc.ToString("F2", CultureInfo.InvariantCulture)}");
}
if (imc > 18 && imc < 25)
{
    Console.WriteLine($"O {nome} está com o peso normal. Seu IMC é de: {imc.ToString("F2", CultureInfo.InvariantCulture)}");
}
if (imc > 25 && imc < 30)
{
    Console.WriteLine($"O {nome} está com sobre peso. Seu IMC é de: {imc.ToString("F2", CultureInfo.InvariantCulture)}");
}
if (imc > 30 && imc < 35)
{
    Console.WriteLine($"O {nome} está com obesidade. Seu IMC é de: {imc.ToString("F2", CultureInfo.InvariantCulture)}");
}
if (imc > 35 )
{
    Console.WriteLine($"O {nome} está com obesidade em um grau avançado e necessita de atenção. Seu IMC é de: {imc.ToString("F2", CultureInfo.InvariantCulture)}");
}
