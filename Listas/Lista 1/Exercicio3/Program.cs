using System;

class Program
{
    public static void Main (string[] args)
    {

        Console.WriteLine("Digite o valor que deseja converter para reais: ");

        int valorInicial = int.Parse(Console.ReadLine());
        int reais = valorInicial/ 100;

        int centavos = valorInicial% 100;

        Console.WriteLine("O total em dinheiro é: " + reais + "reais e " + centavos + "centavos" );

    }
}