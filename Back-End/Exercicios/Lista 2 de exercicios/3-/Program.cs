

Console.WriteLine($"Digite um numero inteiro e descubra sua tabuada:");
int  tabuada = int.Parse(Console.ReadLine());


for (int i = 1; i <= 10; i++ )
{
    Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
    
}
