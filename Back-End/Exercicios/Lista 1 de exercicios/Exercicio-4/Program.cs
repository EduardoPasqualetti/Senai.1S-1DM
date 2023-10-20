// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao sistema!");

Console.WriteLine($"Digite a senha:");
int senha = int.Parse(Console.ReadLine());


if (senha == 1234)
{
    Console.WriteLine($"ACESSO    PERMITIDO");
    
}
else
{
    Console.WriteLine($"ACESSO    NEGADO");
    
}

