namespace Projeto_Calculadora_Classe
{
    

    public class Calculadora
    {
    public float operacao;
    public float num1;
    public float num2;
    public float resultado;

        public float Somar(float num1, float num2)
        {
            return num1 + num2;
        }
        
        public float Subtrair(float num1, float num2)
        {
            return num1 - num2;
        }
        
        public float Multiplicar(float num1, float num2)
        {
            return num1 * num2;
        }
        
        public float Dividir(float num1, float num2)
        {
            if(num2 == 0)
            {
                Console.WriteLine($"Nao e possivel dividir por 0");
                
            }
            return num1 / num2;
        }
    }
}