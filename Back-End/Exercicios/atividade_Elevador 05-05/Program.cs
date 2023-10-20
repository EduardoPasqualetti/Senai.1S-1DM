using exer.elevador;

Elevador elevador = new Elevador();

string subirOuDescer;
string SimouNao;

Console.WriteLine($"Bem vindo ao predio, chame o elevador!");
Console.ReadLine();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine($"Elevador chegou");
Console.ResetColor();
do
{
    for (var i = 0; i < 2; i++)
    {
        elevador.Entrar();

        do
        {
            Console.WriteLine($"Deseja subir ou descer?");
            subirOuDescer = Console.ReadLine().ToLower();

            if (subirOuDescer == "subir")
            {
                elevador.Subir();
            }
            else if (subirOuDescer == "descer")
            {
                elevador.Descer();
            }
            else
            {
                Console.WriteLine($"Opcao invalida");

            }

        } while (subirOuDescer != "subir" && subirOuDescer != "descer");

        elevador.Sair();

    }
    Console.WriteLine($"Deseja continuar o sistema? (S/N)");
    SimouNao = (Console.ReadLine().ToLower());


} while (SimouNao == "s");

Console.WriteLine($"Obrigado, volte sempre!");
