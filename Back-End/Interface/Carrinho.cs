

namespace Produto_interface
{
    public class Carrinho : ICarrinho
    {
        public float valor {get; set;}

        List<Produto> carrinho =  new List<Produto>();

        public void Adicionar(Produto produto)
        {
            carrinho.Add(produto);
        }
        public void Listar()
        {
           if (carrinho.Count != 0 )
           {
            // Produto = var
            foreach (Produto p in carrinho)
            {
                Console.WriteLine($"Codigo: {p.Codigo} - Nome: {p.Nome} - Preco: {p.Preco:C}");
            }
           }
           else
           {
            Console.WriteLine($"Carrinho vazio!");
            
           }
        }

        public void Atualizar(int codigo, Produto novoProduto)
        {
            carrinho.Find(x => x.Codigo == codigo).Nome = novoProduto.Nome;
            carrinho.Find(X => X.Codigo == codigo).Preco = novoProduto.Preco;
        }


        public void Remover(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void ValorTotal()
        {
            valor = 0;

            if (carrinho.Count > 0 || carrinho != null)
            {
                foreach (Produto item in carrinho)
                {
                    valor += item.Preco;
                }
                Console.WriteLine($"Valor total do carrinho: {valor}");
                
            }
        }
    }
}