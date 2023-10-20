// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao sistema!");


Console.WriteLine(@$"
------------------------------------
|      Calcular Média de           |
|      um aluno                    |
------------------------------------
");


Console.WriteLine($"Digite a primeira nota:");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a segunda nota:");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a terceira nota:");
float nota3 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a quarta nota:");
float nota4 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a quinta nota:");
float nota5 = float.Parse(Console.ReadLine());


float media = ((nota1 + nota2 + nota3 + nota4 + nota5) / 5 );

Console.BackgroundColor = ConsoleColor.Red;

Console.WriteLine($"A media do aluno é {media}.");

Console.ResetColor();

Console.WriteLine($"Obrigado pelo uso do sistema!");

