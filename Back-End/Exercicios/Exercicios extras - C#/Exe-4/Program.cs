// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao interrogatorio!");

Console.WriteLine($"Responda essas perguntas:");


Console.WriteLine($"Telefonou para a vítima?");
string quest1 = Console.ReadLine();

Console.WriteLine($"Esteve no local do crime?");
string quest2 = Console.ReadLine();

Console.WriteLine($"Mora perto da vítima?");
string quest3 = Console.ReadLine();

Console.WriteLine($"Devia para a vítima?");
string quest4 = Console.ReadLine();

Console.WriteLine($"Já trabalhou com a vítima?");
string quest5 = Console.ReadLine();


int contsim = 0;


if (quest1 == "sim")
{
contsim++;
}

if (quest2 == "sim")
{
contsim++;
}

if (quest3 == "sim")
{
contsim++;
}

if (quest4 == "sim")
{
contsim++;
}

if (quest5 == "sim")
{
contsim++;
}

if (contsim == 2)
{
    Console.WriteLine($"Voce é Suspeito");
    
}

if (contsim == 3 || contsim == 4)
{
    Console.WriteLine($"Voce é Cumplice");
    
}

if (contsim == 5)
{
    Console.WriteLine($"Voce é Culpado");
    
}

if (contsim <= 1)
{
    Console.WriteLine($"Voce é inocente");
    
}