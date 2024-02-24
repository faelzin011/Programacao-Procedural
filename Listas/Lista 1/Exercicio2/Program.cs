using System;

class Program
{
    public static void Main (string[] args)
    {


    Console.WriteLine("Digite a base do triângulo: ");
    double baseDoTriangulo = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a altura do trângulo: ");
    double alturaDoTriangulo = double.Parse(Console.ReadLine());

    double area = (baseDoTriangulo * alturaDoTriangulo) / 2;
    bool resultadoFinal = area > 20;

    Console.WriteLine("A área do triângulo é maior que 20? " + resultadoFinal);



    }
}



