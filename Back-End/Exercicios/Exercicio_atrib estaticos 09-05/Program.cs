using Exercicio_atributos_estaticos;

double opcao;
double valor;
do
{
    Console.WriteLine(@$"
=================================
|            Cambio             |
| Selecione uma opcao:          |
|                               |
| 1 - dolar para real           |
| 2 - real para dolar           |
| 0 - sair                      |
=================================
");
    opcao = double.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 1:
        Console.WriteLine($"Quantos dolares voce deseja converter para reais?");
        valor = double.Parse(Console.ReadLine());

            Console.WriteLine(Cambio.dolarParaReal(valor));
            break;

        case 2:
        Console.WriteLine($"Quantos reais voce deseja converter para dolares?");
        valor = double.Parse(Console.ReadLine());
        
            Console.WriteLine(Cambio.realParaDolar(valor));
            break;

        case 0:
            Console.WriteLine($"Saindo do sistema");

            break;
        default:
            Console.WriteLine($"opcao invalida");
            break;
    }
} while (opcao != 0);





















