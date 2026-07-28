using System.Security.Cryptography;

namespace Trabalho;

class Program
{
    static List<ItemCardapio> listaCardapio = new List<ItemCardapio>();
    static void Main(string[] args)
    {
        string menu = "";
        do
        {
            Console.WriteLine("1) Cadastro de Produto");
            Console.WriteLine("2) Listar Itens");
            Console.WriteLine("3) Aplicar Desconto");
            Console.WriteLine("4) Interromper/Reativar Venda de Produto");
            Console.WriteLine("5) Remover Item por ID");
            Console.WriteLine("0) SAIR");
            string op = Console.ReadLine();
            if (op == "0") menu = "0";
            
            switch (op)
            {
                case "1":
                    Console.Clear();
                    CadastrarItemCardapio();
                    break;
                case "2":
                    Console.Clear();
                    ListarItemCardapio();
                    break;
                case "3":
                    Console.Clear();
                    AplicarDesconto();
                    break;
                case "4":
                    Console.Clear();
                    AtivarDesativar();
                    break;
                case "5":
                    Console.Clear();
                    RemoverPorId();
                    break;
                default: break;
            }
        }while(menu != "0");
    }
    
    public static void CadastrarItemCardapio()
    {
        ItemCardapio item = new ItemCardapio();
        Console.WriteLine("Digite o nome do Item: ");
        item.Nome = Console.ReadLine();
        Console.WriteLine("Digite o categoria do Item: ");
        item.Categoria = Console.ReadLine();
        Console.WriteLine("Digite o valor do Item: ");
        item.DefinirPrecoBase();
        listaCardapio.Add(item);
    }

    public static void ListarItemCardapio()
    {
        foreach (ItemCardapio item in listaCardapio)
        {
            Console.WriteLine(item.Id);
            Console.WriteLine(item.Nome);
            Console.WriteLine(item.Categoria);
            Console.WriteLine(item.PrecoBase);
            if (item.EstaDisponivel) Console.WriteLine("Disponivel para venda ");
            else Console.WriteLine("Indisponivel para venda");
        }
    }

    public static void RemoverPorId()
    {
        Console.WriteLine("Digite o id do Produto");
        int.TryParse(Console.ReadLine(), out int idProduto);
        for (int i = 0; i < listaCardapio.Count; i++)
        {
            if (listaCardapio[i].Id == idProduto) listaCardapio.RemoveAt(i);
        }
    }

    public static void AtivarDesativar()
    {
        Console.WriteLine("Digite o id do Produto");
        int.TryParse(Console.ReadLine(), out int idProduto);
        for (int i = 0; i < listaCardapio.Count; i++)
        {
            if (listaCardapio[i].Id == idProduto)
            {
                if (listaCardapio[i].EstaDisponivel) listaCardapio[i].PausarVendas();
                else  listaCardapio[i].ReativarVendas();
            }
            else 
            {
                Console.WriteLine("Digite um íd valido");
                break;
            }
        }
    }
    
    public static void AplicarDesconto()
    {
        Console.WriteLine("Digite o id do Produto: ");
        int.TryParse(Console.ReadLine(), out int idProduto);
        Console.WriteLine("Digite o desconto a aplicar no Produto: ");
        double.TryParse(Console.ReadLine(), out double desc);
        for (int i = 0; i < listaCardapio.Count; i++)
        {
            if (listaCardapio[i].Id == idProduto)
            { listaCardapio[i].AplicarDesconto(desc); }
            else 
            {
                Console.WriteLine("Digite um íd valido");
                break;
            }
        }
    }
}