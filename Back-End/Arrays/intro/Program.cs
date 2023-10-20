// string carro = "Opala";

// // Console.WriteLine($"Cadastre o nome do carro:");
// // carro = Console.ReadLine();

// Console.WriteLine($"O carro é {carro}");


// string[] carros = new string[4];
// carros[0] = "Tesla";
// carros[1] = "Maverick";
// carros[2] = "Celta 94";
// carros[3] = "Peugeot 307";

// // Console.WriteLine($"Os carros cadastrados sao: {carros[2]}, {carros[1]}, {carros[0]}");



// string[] nomes = new string[5];
// nomes[0] = "Eduardo";
// nomes[1] = "Gustavo";
// nomes[2] = "Joao";
// nomes[3] = "Gabriel";
// nomes[4] = "vinicius";






string[] carros = new string[4];

for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"Infome o carro:");
    carros[i] = Console.ReadLine();
    
}

Console.WriteLine($"Carros cadastrados!");

Console.WriteLine($"Lista dos carros cadastrados:");

// for (int i = 0; i < 4; i++)
// {
//     Console.WriteLine($"Nome do carro: {carros[i]}");
    
// }



foreach (var item in carros)
{
    Console.WriteLine(item);
    
}