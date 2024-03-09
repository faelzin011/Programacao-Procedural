using System;

class Program
{
    static void Main(string[] args)
    {

       System.Console.WriteLine("Digite a quantidade de intes que comprou na loja: ");
       int quantidadeDeProdutos = int.Parse(Console.ReadLine());

       double precoFinalDoProduto = 0;
       const int FRETE_GRATIS = 150;

       int contador = 1;

       while (contado <= quantidadeDeProdutos)
        {
            System.Console.WriteLine("Insira o valor do" + contador + "produto");
            double produto = double.Parse(Console.ReadLine());

            precoFinalDoProduto += produto;

            contador++;
        } 

        if (precoFinalDoProduto > FRETE_GRATIS)
        {
            System.Console.WriteLine("Parabens! Voce ganhou frete gratis em sua compra de valor " + precoFinalDoProduto);
        }

        else
        {
            System.Console.WriteLine("A compra nao possui frete gratis");
        }

    }   
} 