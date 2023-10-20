// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao sistema!");


Console.WriteLine($"Informe o tamanho do primeiro lado do triangulo:");
float lado1 = float.Parse(Console.ReadLine());


Console.WriteLine($"Informe o tamanho do segundo lado do triangulo:");
float lado2 = float.Parse(Console.ReadLine());


Console.WriteLine($"Informe o tamanho do terceiro lado do triangulo:");
float lado3 = float.Parse(Console.ReadLine());


if  (lado1 == lado2 && lado2 == lado3) 
{
    Console.WriteLine($"O Triângulo é Equilátero");
    
}
else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3 )
{
    Console.WriteLine($"O Triângulo é Isósceles");
    
}
else 
{
 Console.WriteLine($"O Triângulo é Escaleno");
 
}