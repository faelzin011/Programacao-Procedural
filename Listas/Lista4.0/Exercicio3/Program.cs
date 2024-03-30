using System;

class Program
{
  static void Main(string[] args)
  {
    for(int linha = 0; linha <8; linha++)
    {
      for(int coluna =0; coluna <8; coluna++)
      if(coluna == 0 || coluna == 7 || linha == 7 || linha == 0)
      {
        Tabuleiro.Adicionar(linha, coluna, "C");
      }
    }

    Tabuleiro.ImprimeTabuleiro();
  }  
}

    