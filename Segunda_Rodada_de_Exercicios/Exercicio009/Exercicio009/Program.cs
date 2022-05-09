/*9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.*/

Console.Write("Digite o dado da medição 1: ");
double medicaoA = double.Parse(Console.ReadLine());

Console.Write("Digite o dado da medição 2: ");
double medicaoB = double.Parse(Console.ReadLine());

Console.Write("Digite o dado da medição 3: ");
double medicaoC = double.Parse(Console.ReadLine());

if(medicaoA < 65.0)
{
    Console.WriteLine("Medição 1: Risco de hipoglicemia");
}
else if(medicaoA > 65.00 && medicaoA < 250.0)
{
    Console.WriteLine("Medição 1: Indice glicêmico normal");
}
else if (medicaoA > 251.0)
{
    Console.WriteLine("Medição 1: Risco de hiperglicemia");
}

if (medicaoB < 65.0)
{
    Console.WriteLine("Medição 2: Risco de hipoglicemia");
}
else if (medicaoB > 65.00 && medicaoB < 250.0)
{
    Console.WriteLine("Medição 2: Indice glicêmico normal");
}
else if ((medicaoB > 251.0))
{
    Console.WriteLine("Medição 2: Risco de hiperglicemia");
}

if (medicaoC < 65.0)
{
    Console.WriteLine("Medição 3: Risco de hipoglicemia");
}
else if (medicaoC > 65.00 && medicaoC < 250.0)
{
    Console.WriteLine("Medição 3: Indice glicêmico normal");
}
else if (medicaoC > 251.0)
{
    Console.WriteLine("Medição 3: Risco de hiperglicemia");
}