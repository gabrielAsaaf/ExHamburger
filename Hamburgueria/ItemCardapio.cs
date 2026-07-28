using System.Security.Cryptography;

namespace Trabalho;

public class ItemCardapio
{
    public int Id {get; private set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public double PrecoBase { get; private set; }
    public bool EstaDisponivel { get; private set; }

    public ItemCardapio()
    {
        this.Id = new Random().Next(0,100);
        this.EstaDisponivel = true;
    }

    public double DefinirPrecoBase()
    {
        if (double.TryParse(Console.ReadLine(), out double valor)) this.PrecoBase = valor;
        else if (valor > 0) this.PrecoBase = valor;
        else Console.WriteLine("Digite um valor válido e maior que Zero: ");
        return this.PrecoBase;
    }
    
    public void ExcluirItemCardapio()
    {
        Console.WriteLine("Digite o codigo do Item: ");
        int.TryParse(Console.ReadLine(), out int codigo);
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
        if (descPorcent > 0 && descPorcent <= 30)
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