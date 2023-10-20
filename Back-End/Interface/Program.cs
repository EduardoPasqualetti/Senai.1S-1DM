using Produto_interface;

Carrinho carrinho = new Carrinho();
Produto product = new Produto();

string escolha; 

Console.WriteLine($"Bem vindo ao sistema!");
do
{
    Console.WriteLine(@$"
==========================================
|       O que voce deseja fazer ?        |
|                                        |
| (1) - Adicionar um produto ao carrinho |
| (2) - Listar os produtos do carrinho   |
| (3) - Atualizar um produto do carrinho |
| (4) - Remover um produto do carrinho   |
| (5) - Ver o valor total do carrinho    |
| (0) - Sair do sistema                  |
==========================================
");
    escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
          
            Console.WriteLine($"Qual o codigo do Produto a adicionar?");
            product.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual o nome do Produto?");
            product.Nome = Console.ReadLine();

            Console.WriteLine($"Qual o preco do produto?");
            product.Preco = float.Parse(Console.ReadLine());

            carrinho.Adicionar(product);

            Console.WriteLine($"Produto adicionado!");
            break;
        case "2":
            carrinho.Listar();
            break;
        case "3":
            Produto atualizarProduto = new Produto();

            Console.WriteLine($"Qual o codigo do produto que voce deseja atualizar?");
            product.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Deseja atualizar para qual produto?");
            atualizarProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Qual o novo preco do produto?");
            atualizarProduto.Preco = float.Parse(Console.ReadLine());

            carrinho.Atualizar(product.Codigo, atualizarProduto);

            break;
        case "4":
             Console.WriteLine($"Qual o codigo do produto que voce deseja remover?");
             product.Codigo = int.Parse(Console.ReadLine());

            carrinho.Remover(product);

            break;
        case "5":
            carrinho.ValorTotal();

            break;
        case "0":
            Console.WriteLine($"Saindo do sistema...");
            break;
        default:
            Console.WriteLine($"Opcao invalida");
            break;
    }
} while (escolha != "0");