static float ImpostoDeRenda(float n1, float n2)
{
    return (n2 * n1 / 100 ) ;
}

float imposto = 0;

Console.WriteLine($"Informe o seu salario:");
float salario = float.Parse(Console.ReadLine());

if (salario <= 1500 && salario >= 1)
{
   imposto = 0 ;
}
else if (salario <= 3500 && salario >= 1501)
{
    imposto = 20;
}
else if (salario <= 6000 && salario >= 3501)
{
    imposto = 25;
}
else if (salario >= 6000)
{
    imposto = 35;
}
else{
    Console.WriteLine($"x Erro! x");
    
}

Console.WriteLine($"Seu imposto é de R${ImpostoDeRenda(salario, imposto)}");