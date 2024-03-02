using System;

class Program
{
    static void Main (string[] args)
  {

    Console.WriteLine("Digite o nome da crianca: ");
    string rotina = (Console.ReadLine());
    
    if ( rotina == "Filomena")
    {
    
    Console.WriteLine("Rotina da Filomena: ");
    Console.WriteLine("1. Escola das 07h aas 12h");
    Console.WriteLine("2. Almoço das 12h as 13h");
    Console.WriteLine("3. Futebol as 14h as 16h");
    Console.WriteLine("4. Dever de casa das 16h as 18h");
    }    


    if ( rotina == "Joselito")
    {
    
    Console.WriteLine("Rotina de Joselito: ");
    Console.WriteLine("1. Escola das 07h aas 12:30h");
    Console.WriteLine("2. Almoço das 13h as 14h");
    Console.WriteLine("3. Natação as 14h as 16h");
    Console.WriteLine("4. Reforço escolar das 16h as 19h");
    }    

  
  }

}