using System.Security.Cryptography;

namespace Trabalho;

public class ItemCardapio
{
    public int Id {get; private set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public double PrecoBase { get; private set; }
    public bool EstaDisponivel { get; private set; }

    public ItemCardapio(string nome, string categoria, double precoBase)
    {
        this.Id = new Random().Next();
        this.Nome = nome;
        this.Categoria = categoria;
        if(precoBase > 0) this.PrecoBase = precoBase;
        else
        {
            Console.WriteLine("Digite um valor maior que Zero: ");
            this.PrecoBase = Convert.ToDouble(Console.ReadLine());
        }
    }

    public void CadastrarItemCardapio()
    {
        Console.WriteLine("Digite o nome do Item: ");
        this.Nome = Console.ReadLine();
        Console.WriteLine("Digite o categoria do Item: ");
        this.Categoria = Console.ReadLine();
        Console.WriteLine("Digite o valor do Item: ");
        if (double.TryParse(Console.ReadLine(), out double valor)) this.PrecoBase = valor;
        else Console.WriteLine("Digite um valor valido! ");
    }
    
    public bool PausarVendas()
    {
        return this.EstaDisponivel = false;
    }

    public bool ReativarVendas()
    {
        return this.EstaDisponivel = true;
    }
    
    public double AplicarDesconto(double descPorcent)
    {
        if (descPorcent > 0 & descPorcent <= 30)
        {
            this.PrecoBase -= this.PrecoBase * (descPorcent / 100);
        }
        else
        {
            Console.WriteLine("O Desconto não deve ser maior que 30%:");
        }
        return this.PrecoBase;
    }
    
    
}