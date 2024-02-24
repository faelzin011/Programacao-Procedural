using System;

class Program
{
    public static void Main (string[] args)
    {
    
        Console.WriteLine("Digite a sua primeira nota do aluno: ");
        double nota1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a sua segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua quarta nota: ");
        double nota4 = double.Parse(Console.ReadLine());



        double media = (nota1 + nota2 + nota3 + nota4) / 4.0;
        Console.WriteLine("A sua media é: " + media);

    }
}    