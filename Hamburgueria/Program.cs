namespace Trabalho;

class Program
{
    static void Main(string[] args)
    {
        string menu = "";
        List<ItemCardapio> listaCardapio = new List<ItemCardapio>();
        do
        {
            Console.WriteLine("1) Cadastro de Produto");
            Console.WriteLine("2) Listar Cardapio");
            Console.WriteLine("3) Aplicar Desconto");
            Console.WriteLine("4) Interromper Venda de Produto");
            Console.WriteLine("5) Remover Item por ID");
            Console.WriteLine("0) SAIR");
            string op = Console.ReadLine();
            if (op == "0") menu = "0";
            
            switch (op)
            {
                case "1":
                    
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default: break;
            }
        }while(menu != "0");
    }
}