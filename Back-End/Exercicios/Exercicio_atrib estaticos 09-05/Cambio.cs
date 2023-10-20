namespace Exercicio_atributos_estaticos
{
    public class Cambio
    {
        public static double dolarParaReal(double dolar)
        {
            double real = (dolar * 5);

            return real;
        }
        public static double realParaDolar(double real)
        {
            double dolar = (real / 5);

            return dolar;
        }
    }
}