// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao sistema!");


Console.WriteLine($"Digite o raio da circunferencia");
double raio = double.Parse(Console.ReadLine());

double diametro = raio * 2 ;

Console.WriteLine($"O diametro da circunferencia é de {diametro}");
