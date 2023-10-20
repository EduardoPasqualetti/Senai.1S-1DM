// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao sistema!");

Console.WriteLine($"Informe o dia do seu aniversario");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o mes do seu aniversario");
int mes = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o ano do seu aniversario");
int ano = int.Parse(Console.ReadLine());


if (dia <= 31 && mes <= 12 && ano <=2013 )
{
    Console.WriteLine($"A data e valida");
    Console.WriteLine($"{dia}/{mes}/{ano}");
    
    
}
else
{
    Console.WriteLine($"a data e invalida");
    
}