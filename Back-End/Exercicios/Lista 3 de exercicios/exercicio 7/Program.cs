int[] numeros = new int[15];


for (int i = 0; i <= 14; i++)
{
    Console.WriteLine($"Digite o {i + 1}° numero");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Numeros Registrados!");


for (var i = 14; i >= 0 ; i--)
{
    Console.WriteLine(numeros[i]);
    
}