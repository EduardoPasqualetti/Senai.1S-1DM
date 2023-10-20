using PROJETO_MVC.Model;
using PROJETO_MVC.View;

namespace PROJETO_MVC.Controller
{
    public class ProdutoController
    {
        // instanciar objeto produto e produtoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {
            // lista de produtos chamada pela Model
            List<Produto> produtos = produto.Ler();

            // chamado o metodo do View recebendo o argumento da lista a cima como parametro
            produtoView.Listar(produtos);

        }

        public void CadastrarProduto()
        {
            //novo objeto que recebe cada objeto da view a ser inserido no csv
            Produto novoProduto = produtoView.Cadastrar();

            // chamada para a model para inserir esse objeto no csv
            produto.Inserir(novoProduto);
        }
    }
}