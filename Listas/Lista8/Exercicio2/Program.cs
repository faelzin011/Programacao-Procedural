using System;

struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelEmEstoque;
}
class Program
{
    static void Main(string[] args)
    {
        Produto[] produtos = new Produto[4];

        for(int i =0; i < produtos.Length; i++)
        {
            produtos[i].id = Convert.ToInt32(Console.ReadLine());
            produtos[i].nome = Console.ReadLine();
            produtos[i].preco = Convert.ToDouble(Console.ReadLine());
            produtos[i].disponivelEmEstoque = Convert.ToBoolean(Console.ReadLine());
        }

        for(int i =0; i < produtos.Length; i++)
        {
            if(produtos[i].disponivelEmEstoque == true)
            {   
                System.Console.WriteLine("\n");
                System.Console.WriteLine("Produtos que estão disponiveis: ");
                System.Console.WriteLine("\n");
                System.Console.WriteLine(produtos[i].preco);
                System.Console.WriteLine(produtos[i].nome);
            }
        }
        
        
    }
}