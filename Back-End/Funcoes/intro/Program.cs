// static void Saudacao()
// {
//     Console.WriteLine($"Informe o nome da pessoa:");
//     string nome = Console.ReadLine();

//     Console.WriteLine($"Informe o sobrenome da pessoa:");
//     string sobrenome = Console.ReadLine();

//     Console.WriteLine($"Bom dia {nome} {sobrenome}!");
    
// }


// Saudacao();




//          OPERACOES MATEMATICAS EM FUNCOES


// XXXXXXXXXXXXXXXXXX     SOMA DE NUMEROS    XXXXXXXXXXXXXXXXXXXXXX

static float Somar(float n1, float n2)
{
    return (n1 + n2);
}

// Console.WriteLine($"Informe o primeiro numero:");
// float primeiro = float.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o segundo numero:");
// float segundo = float.Parse(Console.ReadLine());

// Console.WriteLine($"A soma de {primeiro} + {segundo} é {Somar(primeiro, segundo)}");


// XXXXXXXXXXXXXXXXXX     SUBTRACAO DE NUMEROS    XXXXXXXXXXXXXXXXXXXXXX

// static float Subtrair(float n1,float n2)
// {
//     return(n1 - n2);
// }

// Console.WriteLine($"Informe o primeiro numero:");
// float num1Subtracao = float.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o segundo numero:");
// float num2Subtracao = float.Parse(Console.ReadLine());

// Console.WriteLine($"A subtracao de {num1Subtracao} - {num2Subtracao} é {Subtrair(num1Subtracao, num2Subtracao)}");


// XXXXXXXXXXXXXXXXXX     MULTIPLICACAO DE NUMEROS    XXXXXXXXXXXXXXXXXXXXXX


//  static float Multiplicar(float n1,float n2)
// {
//     return(n1 * n2);
// }

// Console.WriteLine($"Informe o primeiro numero:");
// float num1Mult = float.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o segundo numero:");
// float num2Mult = float.Parse(Console.ReadLine());

// Console.WriteLine($"A Multiplicacao de {num1Mult} x {num2Mult} é {Multiplicar(num1Mult, num2Mult)}");




// XXXXXXXXXXXXXXXXXX     DVISAO DE NUMEROS    XXXXXXXXXXXXXXXXXXXXXX

// static float Divisao(float n1,float n2)
// {
//     return(n1 / n2);
// }

// Console.WriteLine($"Informe o primeiro numero:");
// float num1Div = float.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o segundo numero:");
// float num2Div = float.Parse(Console.ReadLine());

// Console.WriteLine($"A divisao de {num1Div} ÷ {num2Div} é {Divisao(num1Div, num2Div)}");



//MOSTRAR HORARIO USANDO FUNCAO

// static int MostrarHora()
// {
//     return DateTime.Now.Hour;
// }

// Console.WriteLine($"{MostrarHora()}");




static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(texto);
    
    for (var i = 0; i < quantidadePontinhos; i++)
    {
        Console.Write($".");
        Thread.Sleep(tempo);

    }
    Console.ResetColor();
}

BarraCarregamento("Inicializando", 6, 1000);

BarraCarregamento("Testando", 12, 500);

BarraCarregamento("Aguarde", 3, 2000);

BarraCarregamento("Cadastrando", 105, 50);

BarraCarregamento("Logando", 20, 300);


