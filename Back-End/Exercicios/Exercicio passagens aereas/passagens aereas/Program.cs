Console.WriteLine(@$"
------------------------------
|    Bem vindo ao sistema!   |  
|  Faca login para acessar   |
|        o sistema           |
------------------------------
");

Console.WriteLine($"Digite a senha padrao:");
string senha = Console.ReadLine();

while (senha != "123456")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Senha invalida, tente novamente!");
    Console.ResetColor();
    senha = Console.ReadLine();
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Voce esta logado!");
Console.ResetColor();

Console.WriteLine(@$"Informe o que voce deseja fazer:
--------------------------
|  1- Cadastrar passagem |
|  2- Listar passagens   |
|  0- Sair               |
--------------------------
");
int escolhaDoMenu = int.Parse(Console.ReadLine());

string[] nome = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];
do
{

    if (escolhaDoMenu == 1)
    {
        for (var i = 0; i <= 5; i++)
        {


            Console.WriteLine($"Cadastrar passagem {i + 1}:");

            Console.WriteLine($"Nome do passageiro");
            nome[i] = Console.ReadLine();

            Console.WriteLine($"Origem:");
            origem[i] = Console.ReadLine();

            Console.WriteLine($"Destino:");
            destino[i] = Console.ReadLine();

            Console.WriteLine($"Data do voo:");
            data[i] = Console.ReadLine();

        }
        Console.WriteLine($"Suas passagens foram cadastradas!");
    }
    if (escolhaDoMenu == 2)
    {
        Console.WriteLine($"Suas passagens listadas:");
        for (var i = 0; i <= 5; i++)
        {
            Console.WriteLine(@$"
            Nome do passageiro: {nome[i]}.
            Origem: {origem[i]}.
            Destino: {destino[i]}.
            Data do voo: {data[i]}.
            ");
        }
    }
         Console.WriteLine($"Gostaria de cadastrar outra passagem ? s/n");
         string resposta = Console.ReadLine().toLower(); 

} while (resposta == "s");
Console.WriteLine($"Saiu do Sistema!");



