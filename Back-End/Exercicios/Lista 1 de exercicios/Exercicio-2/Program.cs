// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao sistema!");

Console.WriteLine($"Informe quantos gols o primeiro time fez:");
int time1 = int.Parse(Console.ReadLine());


Console.WriteLine($"Informe quantos gols o segundo time fez:");
int time2 = int.Parse(Console.ReadLine());


if (time1 > time2)
{
    Console.WriteLine($"Vitória do primeiro time");
}

else if (time1 == time2)
{
    Console.WriteLine($"Empate entre as duas equipes");  
}
else
{
    Console.WriteLine($"Vitória do segundo time");
}
