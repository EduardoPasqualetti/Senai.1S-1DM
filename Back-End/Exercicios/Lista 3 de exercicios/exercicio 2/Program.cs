double ValorAlcool = 4.9 ;
double valorGasolina = 5.3 ;

 static double Preco(double n1 /*se vai ser g ou a*/, double n2 /*quanto de combutivel*/, double n3 /*valor do a*/, double n4 /*valor g*/)
{
    if (n1 == 'a' && 'a' <= 20)
    {
        return Math.Round(((n4 * n2) * 0.97f), 2);
    }
    else if (n1 == 'a' && 'a' >= 21)
    {
        return Math.Round(((n4 * n2) * 0.95f), 2);
    }
    else if (n1 == 'g' && 'g' <= 20)
    {
        return Math.Round(((n4 * n2) * 0.96f), 2);
    }
    else if (n1 == 'g' && 'g' >= 21)
    {
        return Math.Round(((n4 * n2) * 0.94f), 2);
    }
    else{
        Console.WriteLine($"Error");
        return(n1);
    }
}
Console.WriteLine(@$"
------------------------------
|     Bem vindo ao posto!    |
|  Escolha seu combustivel:  |   
|(g) Gasolina: R$ 5,30       |
|(a) Alcool: R$4,90          |
------------------------------
");
char combustivel = char.Parse(Console.ReadLine().ToLower());

Console.WriteLine($"Quantos litros voce deseja ?");
float litros = float.Parse(Console.ReadLine().ToLower());

Console.WriteLine($"O Valor a ser pago é de {Preco(combustivel, litros, ValorAlcool, valorGasolina)}");
