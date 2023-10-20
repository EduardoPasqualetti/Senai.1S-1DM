int anoHoje = DateTime.Now.Year;
int idade;

static int Voto(int n1, int n2)
{
   return (n1 - n2);
}

Console.WriteLine($"Informe o ano que voce nasceu");
int anoQueNasceu = int.Parse(Console.ReadLine());

idade = Voto(anoHoje, anoQueNasceu);

if (idade >= 16)
{
    Console.WriteLine($"Voce Pode Votar!");
    
}
else{
    Console.WriteLine($"Voce ainda nao pode votar!");
    
}
