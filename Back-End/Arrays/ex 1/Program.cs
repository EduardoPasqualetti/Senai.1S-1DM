int[] numeros = new int[5];


for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1}^ numero:");
    numeros[i] = int.Parse(Console.ReadLine());
    
}

Console.WriteLine($"Numeros cadastrados");


foreach (var item in numeros)
{
    Console.WriteLine($"O dobro de {item}:");
    
    Console.WriteLine((item * 2));
    
}
