

Console.WriteLine($"Digite sua nota:");
int nota = int.Parse(Console.ReadLine());

while (nota > 10 || nota < 0)
{
    Console.WriteLine($"Nota Invalida");
    nota = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Nota valida, obrigado!");
