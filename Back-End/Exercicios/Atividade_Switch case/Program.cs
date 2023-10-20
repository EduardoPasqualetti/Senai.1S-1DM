// See https://aka.ms/new-console-template for more information


Console.WriteLine(@$"
------------------------------------------------------
|                 Menu de Bebidas                    | 
|      Escolha a bebida que voce deseja beber:       |
| 1 - Coca cola                                      |
| 2 - Guarana                                         |
| 3 - Agua sem gas                                    |
| 4 - Agua com gas                                    |
| 5 - Energetico                                      |
------------------------------------------------------
") ;

char bebida = char.Parse (Console.ReadLine());


Console.WriteLine($"Voce gostaria de gelo no copo?");
string gelo = Console.ReadLine().ToLower();


switch (bebida)
{
    case '1':
    if (gelo == "sim") 
    
        Console.WriteLine($"Sua bebida: Coca cola com gelo");
    
    else
    {
        Console.WriteLine($"Sua bebida: Coca cola sem gelo");
        
    }
    break;

    case '2':
    if (gelo == "sim") 
    
        Console.WriteLine($"Sua bebida: Guarana com gelo");
    
    else
    {
        Console.WriteLine($"Sua bebida: Guarana sem gelo");
        
    }
    break;

    case '3':
    if (gelo == "sim") 
    
        Console.WriteLine($"Sua bebida: Agua sem gas com gelo");
    
    else
    {
        Console.WriteLine($"Sua bebida: Agua sem gas sem gelo");
        
    }
    break;

    case '4':
    if (gelo == "sim") 
    
        Console.WriteLine($"Sua bebida: Agua com gas com gelo");
    
    else
    {
        Console.WriteLine($"Sua bebida: Agua com gas sem gelo");
        
    }
    break;

    case '5':
    if (gelo == "sim") 
    
        Console.WriteLine($"Sua bebida: Energetico com gelo");
    
    else
    {
        Console.WriteLine($"Sua bebida: Energetico sem gelo");
        
    }
    break;
}

