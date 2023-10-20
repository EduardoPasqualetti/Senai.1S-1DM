// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao sistema!");


Console.WriteLine($"Informe a quantidade de macas compradas");
double macas = double.Parse(Console.ReadLine());

    double menor = (macas * 0.30) ;
    double maior = (macas * 0.25) ;

if (macas < 12)
{
    Console.WriteLine($"Valor total das maças: {menor}$");
    
}
else 
{
    Console.WriteLine($"Valor total das maças: {maior}$");
    
}
