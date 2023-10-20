// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao sistema!");

Console.WriteLine($"Digite o primeiro numero");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o primeiro numero");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o primeiro numero");
float n3 = float.Parse(Console.ReadLine());



if (n1 > n2 && n2>n3)
{
Console.WriteLine($"{n1}{n2}{n3}");
Console.WriteLine($"{n3}{n2}{n1}");

}

if (n1 > n3 && n3 > n2)
{
Console.WriteLine($"{n1}{n3}{n2}");
Console.WriteLine($"{n2}{n3}{n1}");

}

if (n2 > n1 && n1 > n3)
{
    Console.WriteLine($"{n2}{n1}{n3}");
    Console.WriteLine($"{n3}{n1}{n2}");
    
}

if (n2 > n3 && n3 > n1)
{
    Console.WriteLine($"{n2}{n3}{n1}");
    Console.WriteLine($"{n1}{n3}{n2}");
    
}

if (n3 > n2 && n2 > n1)
{
    Console.WriteLine($"{n3}{n2}{n1}");
    Console.WriteLine($"{n1}{n2}{n3}");
    
}
if (n3 > n1 && n1 > n2)
{
    Console.WriteLine($"{n3}{n1}{n2}");
    Console.WriteLine($"{n2}{n1}{n3}");
    
}