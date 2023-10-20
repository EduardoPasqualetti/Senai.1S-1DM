

Console.WriteLine($"Digite o seu nome de usuario:");
string nome = Console.ReadLine();

Console.WriteLine($"Digite sua senha:");
string senha = Console.ReadLine();

while (senha == nome)
{
    Console.WriteLine($"Erro, a senha nao pode ser igual ao nome de usuario");
    Console.WriteLine($" Digite novamente, Nome:");
    nome = Console.ReadLine();

    Console.WriteLine($"Senha:");
    senha = Console.ReadLine();
    
}
Console.WriteLine($"Usuario e senha cadastrado!");
