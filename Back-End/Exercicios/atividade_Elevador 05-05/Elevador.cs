namespace exer.elevador
{
    public class Elevador
    {
        public int andarAtual = 0;
        public int totalAndares = 10;
        public int pessoas = 0;
        public int capacidadePessoas = 8;
        public int quantasPessoas { get; set; }
        public int quantosAndares { get; set; }
        public void Inicializa()
        {

        }
        public void Entrar()
        {
            do
            {
                Console.WriteLine($"Quantas pessoas vao entrar?");
                quantasPessoas = int.Parse(Console.ReadLine());

                if (quantasPessoas <= capacidadePessoas)
                {

                    if (pessoas < capacidadePessoas)
                    {
                        pessoas = pessoas + quantasPessoas;

                    }
                    else
                    {
                        Console.WriteLine($"Limite de pessoas atingido, so podem 8 pessoas no elevador.");
                        quantasPessoas = 0;
                    }
                }
                else if (quantasPessoas > capacidadePessoas)
                {
                    Console.WriteLine($"So podem 8 pessoas dentro do elevador");
                    quantasPessoas= 0 ;
                }
            } while (pessoas > capacidadePessoas || quantasPessoas > capacidadePessoas);
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"O elevador possui {pessoas} pessoas dentro dele");
            Console.ResetColor();
        }
        public void Sair()
        {
            Console.WriteLine($"Quantas pessoas vao sair do elevador?");
            quantasPessoas = int.Parse(Console.ReadLine());

            if (pessoas >= 1)
            {
                if (quantasPessoas > pessoas)
                {
                    Console.WriteLine($"Nao possui essa quantidade de pessoas dentro do elevador!");
                    quantasPessoas = 0;
                }
                else if (quantasPessoas < pessoas)
                    pessoas = pessoas - quantasPessoas;
            }
            else
            {
                Console.WriteLine($"Nao ha ninguem no elevador!");
                quantasPessoas = 0;
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"O elevador possui {pessoas} pessoas dentro dele");
            Console.ResetColor();
        }
        public void Subir()
        {
            do
            {
                Console.WriteLine($"Quantos andares voce deseja subir ?");
                quantosAndares = int.Parse(Console.ReadLine());

                if (quantosAndares > totalAndares)
                {
                    Console.WriteLine($"O predio so possui 10 andares");
                    

                }
                else if (quantosAndares <= totalAndares)
                {
                    if (andarAtual + quantosAndares <= 10)
                    {
                        andarAtual = andarAtual + quantosAndares;
                    }
                    else if (andarAtual + quantosAndares > 10)
                    {
                        Console.WriteLine($"O predio so possui 10 andares");
                        quantosAndares = 0;
                    }
                }
            } while (andarAtual + quantosAndares > 10);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"O elevador esta no {andarAtual} andar");
            Console.ResetColor();
        }
        public void Descer()
        {
            do
            {
                Console.WriteLine($"Quantos andares voce deseja descer ?");
                quantosAndares = int.Parse(Console.ReadLine());

                if (andarAtual < 1)
                {
                    Console.WriteLine($"O elevador ja esta no terreo");
                    quantosAndares = 0;
                }
                else
                {
                    if (andarAtual - quantosAndares < 0)
                    {
                        Console.WriteLine($"O elevador so pode descer ate o terreo");
                        quantosAndares = 0;

                    }
                    else if (andarAtual - quantosAndares > 0)
                    {
                        andarAtual = andarAtual - quantosAndares;
                    }
                }
            } while (andarAtual - quantosAndares < 0);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"O elevador esta no {andarAtual} andar");
            Console.ResetColor();
        }

        public void Exibir()
        {
            Console.WriteLine(@$"
            Quantidade de pessoas no elevador: {pessoas}
            Andar que o elevador esta: {andarAtual}
            ");

        }
    }
}
