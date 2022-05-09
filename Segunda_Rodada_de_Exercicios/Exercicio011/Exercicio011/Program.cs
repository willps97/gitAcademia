/*11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
O programa deve exibir se a hora digitada está ou não válida. 
Lembre que usaremos o padrão de hora com 24h, de 0 a 23.*/

Console.Write("Digite a Hora (HH): ");
int hora = int.Parse(Console.ReadLine());

Console.Write("Digite os minutos (MM): ");
int minutos = int.Parse(Console.ReadLine());

if(hora > 23 || hora < 0)
{
    Console.WriteLine("Hora inválida!");
}

else if (minutos > 60 || minutos < 0)
{
    Console.WriteLine("minuto inválido!");
}

else
{
    Console.WriteLine("A hora digitada foi: " + hora + " : " + minutos);
}