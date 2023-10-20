

Console.WriteLine($"Digite o seu nome:");
string nome = Console.ReadLine();

while (nome == "")
{
    Console.WriteLine($"Digite seu nome corretamente:");
    nome = Console.ReadLine();
}

 Console.WriteLine($"Nome registrado!");


Console.WriteLine($"Digite sua idade:");
int idade = int.Parse(Console.ReadLine());


while ( idade > 100)
{
    Console.WriteLine($"Idade invalida, digite sua idade correta!");
     idade = int.Parse(Console.ReadLine());

}

Console.WriteLine($"Idade Registrada!");



Console.WriteLine($"Digite o seu salario:");
float salario = float.Parse(Console.ReadLine());

while (salario <= 0)
{
    Console.WriteLine($"Invalido, digite seu salario corretamente!");
    salario = float.Parse(Console.ReadLine());
    
}
Console.WriteLine($"Salario registrado!");



Console.WriteLine(@$"
    ----------------------------
    | Informe seu estado civil | 
    | 's'(solteiro(a))         |
    | 'c'(casado(a))           |
    | 'v'(viuvo(a))            |
    | 'd'(divorciado(a))       |
    ----------------------------
");
char estado = char.Parse(Console.ReadLine().ToLower());

while (estado != 's' && estado != 'c' && estado != 'v' && estado != 'd')
{ 

    Console.WriteLine($"Estado civil invalido, por favor digite a letra que represente seu estado civil, como acima!");
        estado = char.Parse(Console.ReadLine());

}

if (estado == 's')
{
    Console.WriteLine($"Seu estado civil: Solteiro! ");
}
else if (estado == 'c')
{
    Console.WriteLine($"Seu estado civil: Casado! ");
}
else if (estado == 'v')
{
    Console.WriteLine($"Seu estado civil: Viuvo! ");
}
if (estado == 'd')
{
    Console.WriteLine($"Seu estado civil: Divorciado! ");
}


Console.WriteLine($"Seus dados: {nome}, {idade} anos, Salario: {salario} e Estado civil: {estado}. Obrigado!");
