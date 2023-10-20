// 1) mostrar um texto na tela
// 2) escolher uma opcao que queira ver
// 3) chamar a funcionalidade
// quando finalizar, repetir o processo ate o usuario quiser parar - criar um loop


string opcao;
string[] nome = new string[10];
float[] preco = new float[10];
string[] promocao = new string[10];

string deseja;


do
{
    
    Console.WriteLine(@$"
|                               |
|          Programa Menu        |
|   Escolha uma opcao abaixo:   |
|                               |
|  1) Cadastrar Produto         |
|  2) Listar Produto            |
|  0) Sair                      |
|                               |
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            for (var i = 0; i <= 2; i++)
            {


                Console.WriteLine($"Informe o nome do produto {i + 1}:");
                nome[i] = Console.ReadLine();

                Console.WriteLine($"Informe o preco do produto {i + 1}:");
                preco[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"O produto {i + 1} esta na promocao: (s/n)");
                promocao[i] = Console.ReadLine().ToLower();

            }
            break;

        case "2":

            for (var i = 0; i <= 2; i++)
            {
                if (promocao[i] == "s")
                {
                    promocao[i] = "Esta na promocao";
                }
                else if (promocao[i] == "n")
                {
                    promocao[i] = "Nao esta na promocao";
                }
                else if (promocao[i] != "s" && promocao[i] != "n")
                {
                    Console.WriteLine($"Invalido");
                    
                }
                else
                {
                    Console.WriteLine($"erro");
                    
                }


                Console.WriteLine(@$"
                Lista:
             {nome[i]}   
             R${preco[i]}   
             {promocao[i]}
                ");
            }

            break;
        case "0":
            Console.WriteLine($"Tchau, obrigado");
            break;
        default:
            Console.WriteLine($"opcao invalida");
            break;
    }

    Console.WriteLine($"Deseja vizualizer o menu novamente? (s/n)");
    deseja = Console.ReadLine();
    
} while (deseja == "s");

Console.WriteLine($"Tchau, obrigado");
