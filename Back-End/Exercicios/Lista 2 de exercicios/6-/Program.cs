

Console.WriteLine($"DIgite -sim- se vc quer ver a tabuada de 1 a 10");
string tabuada = Console.ReadLine().ToLower();

for (int i = 1; i <= 10; i++)
{
 for (int z = 1; z <= 10; z++)
 {
    Console.WriteLine($"{i} x {z} = {i * z}");
    
 }
}


