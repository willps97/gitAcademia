/*4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles.
 *Mostrar na tela qual dos professores tem o maior salário total.
 */

Console.WriteLine("Digite a quantidade de horas/aula do professor A: ");
int horasProfA = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de horas/aula do professor B: ");
int horasProfB = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor (R$) da hora/aula do professor A: ");
double valorHoraA = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor (R$) da hora/aula do professor B: ");
double valorHoraB = double.Parse(Console.ReadLine());

double totalProfessorA = horasProfA * valorHoraA;
double totalProfessorB = horasProfB * valorHoraB;

Console.WriteLine($"O salário do professor A é de: R$:{totalProfessorA}. O do professor B é de R$:{totalProfessorB}");
if(totalProfessorA > totalProfessorB)
{
    Console.WriteLine("O salário do professor A é maior do que o do professor B.");
}
else
{
    Console.WriteLine("O salário do professor B é maior do que o do professor A.");
}