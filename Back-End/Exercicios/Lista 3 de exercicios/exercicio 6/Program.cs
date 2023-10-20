string[] nomes = new string [10];


for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Informe o {i + 1}° nome:");
    nomes[i] = Console.ReadLine().ToLower();
}

Console.WriteLine($"Nomes Registrados!");


Console.WriteLine($"Informe um nome que voce deseja verificar se esta na lista:");
string buscarNome = Console.ReadLine().ToLower();


if (nomes.Contains(buscarNome))
{
    Console.WriteLine($"ACHEI!");
}
else 
{
    Console.WriteLine($"NAO ACHEI!");
}



