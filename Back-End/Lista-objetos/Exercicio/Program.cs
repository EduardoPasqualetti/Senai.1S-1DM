using Exercicio;

List<Carro> carros = new List<Carro>();

for (int i = 0; i < 2; i++)
{
    Carro carro = new Carro();

    Console.WriteLine($"Qual a marca do carro {i + 1} ?");
    carro.Marca = Console.ReadLine();

    Console.WriteLine($"Qual a cor do carro {i + 1} ?");
    carro.Cor = Console.ReadLine();

    carros.Add(carro);
}
foreach (var item in carros)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@$"
        Carro:
    Marca: {item.Marca}
    Cor: {item.Cor}
    Indice: {carros.IndexOf(item)}
    ");
    Console.ResetColor();
}
