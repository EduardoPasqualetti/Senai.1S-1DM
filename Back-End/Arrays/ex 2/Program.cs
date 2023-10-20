string[] nomes = new string[5];

int[] idades = new int[5];

for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1}° Nome:");
    nomes[i] = Console.ReadLine();

    Console.WriteLine($"Digite a {i + 1}° idades:");
    idades[i] = int.Parse(Console.ReadLine());
}

for (var i = 0; i < 5; i++)
{
    Console.ForegroundColor= ConsoleColor.Blue;
    Console.WriteLine($"{i + 1}) Nome: {nomes[i]}");
    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine($"   Idade: {idades[i]} Anos.");
    Console.ResetColor();
    Console.WriteLine($"");  
}