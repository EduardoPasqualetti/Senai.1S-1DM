// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao sistema!");


Console.WriteLine($"Digite a letra:");
string letra = (Console.ReadLine());


if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
{
    Console.WriteLine($"Essa letra e uma vogal!");
    
}
else{
    Console.WriteLine($"Essa letra e uma consoante!");
    
}
