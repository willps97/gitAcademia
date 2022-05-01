using System.Globalization;

/*9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis. 
Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
da entrada e das duas prestações, de acordo com as regras acima. 
Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
conseqüente pagamento dos boletos das duas prestações.*/

double total, resto;
Console.WriteLine("Digite o valor a ser pago: ");
double entrada = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

if (entrada % 3 == 0)
{
    total = entrada / 3;
    Console.WriteLine($"A entrada e as duas parcelas serão de R$ {total.ToString("F2",CultureInfo.InvariantCulture)}");
}
else
{
    resto = entrada % 3;
    total = (int)entrada / 3;
    double somaEntrada = resto + total;

    Console.WriteLine($"A entrada é de R$ {somaEntrada.ToString("F2",CultureInfo.InvariantCulture)} e as duas parcelas serão de R$ {total.ToString("F2",CultureInfo.InvariantCulture)}");

}