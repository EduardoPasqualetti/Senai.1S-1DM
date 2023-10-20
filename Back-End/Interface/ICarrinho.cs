namespace Produto_interface
{
    public interface ICarrinho
    {
        //declarar quais os metodos deverao ser implementados na classe que herdar a interface

        // CRUD: Create / Read / Update / Delete

        // Create
        void Adicionar(Produto produto);

        // Read

        void Listar();

        // Update
         void Atualizar(int codigo, Produto novoProduto);

         // Delete

         void Remover(Produto produto);


         // Valor total
         void ValorTotal();
    }
}