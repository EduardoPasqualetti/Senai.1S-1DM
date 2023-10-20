using Projeto_Aluno_POO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cadastro de Aluno");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Curso: ");
        string curso = Console.ReadLine();
        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());
        Console.Write("RG: ");
        string rg = Console.ReadLine();
        Console.Write("Bolsista? (S/N): ");
        bool bolsista = Console.ReadLine().ToLower() == "s" ? true : false;
        Console.Write("Media Final: ");
        double mediaFinal = double.Parse(Console.ReadLine());
        Console.Write("Valor da Mensalidade: ");
        double valorMensalidade = double.Parse(Console.ReadLine());

        Aluno aluno = new Aluno()
        {
            Nome = nome,
            Curso = curso,
            Idade = idade,
            RG = rg,
            Bolsista = bolsista,
            MediaFinal = mediaFinal,
            ValorMensalidade = valorMensalidade
        };
        int opcao = 0;
        do
        {
            Console.WriteLine(@$"
           Escolha uma opção:

          1 - Ver Media Final
          2 - Ver Valor da Mensalidade
          0 - Sair
        ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    aluno.VerMediaFinal();
                    break;
                case 2:
                    aluno.VerMensalidade();
                    break;
                case 0:
                    Console.WriteLine($"Saindo do programa");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 0);
    }
}