int[] idade = new int[10];
char sexo;
float peso;

int totalMulher = 0;
int totalHomem = 0;

int resposta = 0;




for (var i = 0; i <= 2; i++)
{
    Console.WriteLine($"{i + 1}° Pessoa:");
    Console.WriteLine($"Idade:");
    idade[i] = int.Parse(Console.ReadLine());

    Console.WriteLine(@$"
    Qual o seu sexo?
    (m) - Masculino
    (f) - Feminino 
    ");
    sexo = char.Parse(Console.ReadLine().ToLower());

    if (sexo == 'm')
    {
        totalHomem++;
    }
    else if (sexo == 'f')
    {
        totalMulher++;
    }
    else
    {
        Console.WriteLine($"xxxxxxxx ERRO xxxxxxxxx");
        
    }
    Console.WriteLine($"Digite seu peso:");
    peso = float.Parse(Console.ReadLine());
}


Console.WriteLine(@$"
Total de Homens: {totalHomem}
Total de Mulheres: {totalMulher}
");
