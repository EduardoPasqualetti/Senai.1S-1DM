//declarar as variáveis
string[] nomes = new string[2];
string[] origens = new string[2];
string[] destinos = new string[2];
string[] datas = new string[2]; //data = "dd/mm/aaaa"


//criar as funções

//função para Efetuar Login
static bool Login(string senha)
{
    if (senha == "123456")
    {
        return true;
    }
    else
    {
        Console.WriteLine($"Senha incorreta!");
        return false;
    }
}


Console.WriteLine($"****************************");
Console.WriteLine($"*****Agência de Viagens*****");
Console.WriteLine($"****************************");

bool senhaValida;

//validação de senha
do
{
    Console.WriteLine($"Informe a senha padrão: ");
    string senha = Console.ReadLine();

    senhaValida = Login(senha);

} while (senhaValida == false);


string escolha;

do
{
    //menu de opções
Console.WriteLine($"*****Menu inicial*****");
Console.WriteLine($"Selecione uma opção:");
Console.WriteLine($"[1] - Cadastro");
Console.WriteLine($"[2] - Listar");
Console.WriteLine($"[0] - Sair");

escolha = Console.ReadLine();

switch (escolha)
{
    case "1":

        string resposta;

        do
        {
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine($"Informe o nome: ");
                nomes[i] = Console.ReadLine();

                Console.WriteLine($"Informe a origem: ");
                origens[i] = Console.ReadLine();

                Console.WriteLine($"Informe o destino: ");
                destinos[i] = Console.ReadLine();

                Console.WriteLine($"Informe a data: ");
                datas[i] = Console.ReadLine();
            }

            Console.WriteLine($"Gostaria de cadastrar uma nova passagem ? s/n");
            resposta = Console.ReadLine().ToLower();

        } while (resposta == "s");
        break;
    case "2":
        for (var i = 0; i < 2; i++)
        {
            Console.WriteLine(@$"
            -------------------
            Bilhete de Passagem

            Nome: {nomes[i]}
            Origem: {origens[i]}
            Destino: {destinos[i]}
            Data: {datas[i]}            
            ");
        }
        break;
    case "0":
        Console.WriteLine($"Fim");
        break;
    default:
        Console.WriteLine($"Opção inválida");
        break;
}
} while (escolha != "0");