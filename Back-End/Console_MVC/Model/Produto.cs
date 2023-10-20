namespace PROJETO_MVC.Model
{
    public class Produto
    {
        // Propriedades
        public int Codigo {get; set;}
        public string Nome {get; set;}
        public float Preco {get; set;}

        // Caminho da pasta e do arquivo definido
        private const string PATH =  "Database/Produto.csv";

        // Criar um construtor
        public Produto()
        {
            // Obter o caminho da pasta
            string pasta = PATH.Split("/")[0]; //Database

            // Se nao existir uma pasta Database, criar-se uma
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
                        // Se nao existir um arquivo csv no caminho, criar-se uma
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Produto> Ler()
        {
            // Instanciar uma lista
            List<Produto> produto = new List<Produto>();

            // Array de string que recebe cada linha do csv
            string[] linhas = File.ReadAllLines(PATH);

            // Leitura das linhas
            foreach (var item in linhas)
            {
                // Array que recebe os itens da linha separado por ";"
                string[] atributos = item.Split(";");
                
                // apos o split
                // atributo[0] = "001"
                // atributo[1] = "Coca"
                // atributo[2] = "6,50"

                // Instanciar o objeto produto
                Produto p = new Produto();

                // Atribuir os dados dentro de um objeto

                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);

                // Adiciona os produtos na lista
                produto.Add(p);
            }

            return produto;
        }

        // Prepara a linha do csv
        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

        // inserir um produto no arquivo csv
        public void Inserir(Produto p)
        {
            // array que vai armazenar as linhas(cada "objeto")
            string[] linhas = {PrepararLinhasCSV(p)};

            //vai ate o arquivo e insere todas as linhas
            File.AppendAllLines(PATH, linhas);
        }
    }
}