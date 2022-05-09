using System.Globalization;

/*12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
No final do processamento, exibir o salário total e o salário excedente do operário.*/

Console.Write("Digite o código do funcionário: ");
string codigo = Console.ReadLine();
Console.Write("Digite a quantidade de horas trabalhadas pelo funcionário: ");
int numeroHoras = int.Parse(Console.ReadLine());
if(numeroHoras > 50)
{
    double salarioNormal = 10.00 * 50;
    double horaExtra = numeroHoras - 50;
    double salarioExtra = horaExtra * 20.00;
    double salarioTotal = salarioNormal + salarioExtra;
    Console.WriteLine($"O salário do funcionário {codigo} é de R$: {salarioTotal.ToString("F2",CultureInfo.InvariantCulture)}.");
}
else
{
    double salario = numeroHoras *10.00;
    Console.WriteLine($"O salário do funcionário {codigo} é de R$: {salario.ToString("F2",CultureInfo.InvariantCulture)}.");

}