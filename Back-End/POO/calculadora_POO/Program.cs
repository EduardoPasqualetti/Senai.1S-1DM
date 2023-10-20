using Projeto_Calculadora_Classe;

Calculadora o1 = new Calculadora();
{
    float num1, num2, resultado;
    char operador;

    Console.WriteLine("Bem-vindo à calculadora!");
    Console.WriteLine(@$"
1) Somar = (+)
2) Subtrair = (-)
3) Multiplicar = (*)
4) Dividir = (/)

");

    Console.WriteLine("Insira o operador:");
    operador = char.Parse(Console.ReadLine());
        
    Console.WriteLine("Insira o primeiro número:");
    num1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Insira o segundo número:");
    num2 = float.Parse(Console.ReadLine());


     switch (operador)
    {
        case '+':
            resultado = num1 + num2;
            Console.WriteLine("Resultado: " + resultado);
            break;
        case '-':
            resultado = num1 - num2;
            Console.WriteLine("Resultado: " + resultado);
            break;
        case '*':
            resultado = num1 * num2;
            Console.WriteLine("Resultado: " + resultado);
            break;
        case '/':
            if (num2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero!");
            }
            else
            {
                resultado = num1 / num2;
                Console.WriteLine("Resultado: " + resultado);
            }
            break;
        default:
            Console.WriteLine("Operador inválido!");
            break;
    }

    Console.ReadKey();
}