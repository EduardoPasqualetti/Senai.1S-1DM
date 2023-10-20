float precoBanana = 3;

static double Compra(double n1, double n2)
{
   
if (n1 <= 5)
{
    return Math.Round(((n1 * n2) * 0.98f), 2);
}
else if (n1 > 5 && n1 <= 10)
{
    return Math.Round(((n1 * n2) * 0.97f), 2);
}
else if (n1 > 10)
{
    return Math.Round(((n1 * n2) * 0.95f), 2);
}
else{
    return (0);
    Console.WriteLine($"Error");
}
}


Console.WriteLine(@$"
--------------------------------------------------
|   Escolha quantas bananas voce quer comprar:   |
|          Valor da Banana: R$ 3,00              |               
--------------------------------------------------
");
double quantidade = double.Parse(Console.ReadLine().ToLower());




Console.WriteLine($"O valor a ser pago é R${Compra(quantidade, precoBanana)}");
