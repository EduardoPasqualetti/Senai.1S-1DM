// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao sistema!");

Console.WriteLine($"Digite seu salario:");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o total gasto:");
float gasto = float.Parse(Console.ReadLine());

if (salario > gasto)
{
    Console.WriteLine($"Gastos dentro do orçamento");
}
else 
{
    Console.WriteLine($"Orçamento estourado");
}