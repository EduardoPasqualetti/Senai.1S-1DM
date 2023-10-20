using PROJETO_MVC.Model;

namespace PROJETO_MVC.View
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos) 
        {
            Console.Clear();
            foreach (var item in produtos)
            {
                Console.WriteLine($"\nCodigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preco: {item.Preco:c}");
            }
        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();
            
            Console.WriteLine($"Informe o codigo:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome:");
            novoProduto.Nome = Console.ReadLine();
            
            Console.WriteLine($"Informe o preco:");
            novoProduto.Preco = float.Parse(Console.ReadLine());
            
            return novoProduto;
        }
    }
}