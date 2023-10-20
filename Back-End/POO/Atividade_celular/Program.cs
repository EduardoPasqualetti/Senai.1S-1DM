using atividade_celular;

Celular c1 = new Celular();

Console.WriteLine($"Informe a cor do celular:");
c1.cor = Console.ReadLine();

Console.WriteLine($"Informe o modelo do celular:");
c1.modelo = Console.ReadLine();

Console.WriteLine($"Informe o tamanho do celular");
c1.tamanho = Console.ReadLine();

Console.WriteLine($"Deseja ligar o celular ? (S/N)");
c1.ligado = Console.ReadLine().ToLower() == "s" ? true : false;

if (c1.ligado == true)
{
    string desejo;

    Console.ForegroundColor = ConsoleColor.Green;
    c1.Ligar();
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine(@$"
  Infos do seu smartphone
  Cor: {c1.cor}
  Modelo: {c1.modelo}
  Tamanho: {c1.tamanho}
  ");
    Console.ResetColor();
    do
    {
        Console.WriteLine(@$"
    Oque voce deseja fazer ?
    1- Fazer uma ligacao?
    2- Enviar uma mensagem
    0- Desligar o celular.
    ");
        desejo = Console.ReadLine();

        switch (desejo)
        {
            case "1":
                Console.WriteLine($"A quem voce deseja enviar mensagem?");
                string pessoaMensagem = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(@$"
                || {c1.Ligacao()} para {pessoaMensagem}... ||
                 ");
                Console.ResetColor();
                break;
            case "2":
                Console.WriteLine($"A quem voce deseja Fazer uma ligacao?");
                string pessoaLigacao = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(@$"
                || {c1.Mensagem()} para {pessoaLigacao}... ||
                ");
                Console.ResetColor();
                break;
            case "0":
                Console.ForegroundColor = ConsoleColor.Red;
                c1.Desligar();
                Console.ResetColor();
                break;
            default:
                Console.WriteLine($"opcao invalida");

                break;
        }

    } while (desejo == "1" || desejo == "2");
    Console.ReadKey();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    c1.Desligar();
    Console.ResetColor();
}