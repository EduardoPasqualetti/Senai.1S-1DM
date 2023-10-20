namespace POO
{
    public class Personagem
    {
        // DECLARAR AS VARIAVEIS
        // ASSINATURA TIPO NOME

        public string nome;
        public int idade;
        public string armadura;
        public string ia;

        // declarar metodos

        public void Atacar()
        {
            Console.WriteLine($"O personagem atacou!");
            
        }
        public string Defender()
        {
            return "O personagem defendeu";
            
        }

        public void RestaurarArmadura()
        {
            Console.WriteLine($"O personagem esta de armadura nova!");
            
        }

    }
}
