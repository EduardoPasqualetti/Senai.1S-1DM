// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao sistema!");


Console.WriteLine($"Para avaliarmos a sua situaçao final, digite sua frequencia:");
int frequencia = int.Parse(Console.ReadLine());

Console.WriteLine($"Entao, digite sua media final:");
int nota = int.Parse(Console.ReadLine());


if (frequencia < 75 )
{
 Console.WriteLine($"Voce esta reprovado");
 
}

else if (nota >= 7)
{
    Console.WriteLine($"Voce esta aprovado");
    
}
else if (nota < 3)
{
 Console.WriteLine($"Voce esta reprovado");
 
}
else 
{
    Console.WriteLine($"Voce tem direito a uma prova de recuperaçao");
    
}