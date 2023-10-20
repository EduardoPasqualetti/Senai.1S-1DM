namespace atividade_celular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;

        public void Ligar()
        {
            Console.WriteLine($"Ligando o celular...");
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando o celular...");

        }

        public string Ligacao()
        {
            return "Fazendo uma ligacao";

        }

        public string Mensagem()
        {
            return "Enviando uma mensagem";

        }
    }
}