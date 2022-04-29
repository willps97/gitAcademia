/*Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
A fórmula da conversão é F=(9*C+160)/5.*/

Console.WriteLine("Digite a temperatura em Celcius que deseja converter para Fahrenheit: ");
double c = double.Parse(Console.ReadLine());

double f = (9 * c + 160) / 5;

Console.WriteLine($"A temperatura convertida é de {f}ºf ");
