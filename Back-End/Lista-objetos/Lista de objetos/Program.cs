using Lista_de_objetos;

List<Produto> listaProdutos = new List<Produto>();

// INSERIR OS OBJETOS DE PRODUTO DENTRO DA LISTA

// modelo 1
listaProdutos.Add(new Produto(1234, "camiseta lacoste", 149.99f));

// modelo 2
Produto camisetaArmani = new Produto(1267, "camiseta armani", 189.99f);
listaProdutos.Add(camisetaArmani);

listaProdutos.Add(new Produto (1378, "blusa da nike", 209.99f));

Produto blusaAdidas = new Produto(1399, "blusa da adidas", 199.99f);
listaProdutos.Add(blusaAdidas);



// READ
// produtos antes da alteracao
foreach (var item in listaProdutos)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Codigo: {item.Codigo}, Nome: {item.Nome}, Preco: {item.Preco:C}");
    Console.ResetColor();
}

// acessar um objeto da lista para poder manipula-lo
Produto produtoEncontrado = listaProdutos.Find(x => x.Codigo == 1267);

//encontrar o indice do produto encontrado
int index = listaProdutos.IndexOf(produtoEncontrado);

Console.WriteLine($"O indice do produto encontrado: {index}");

// fazer alteracoes
produtoEncontrado.Preco = 289.99f;

// remover o item antigo da lista 
listaProdutos.RemoveAt(index);

// devolver o item atualizado no lugar
listaProdutos.Insert(index, produtoEncontrado);

Console.WriteLine($"");
Console.WriteLine($"Lista apos a atualizacao:");



//                                TESTES


Produto Busca = listaProdutos.Find(y => y.Preco == 199.99f);

int indice = listaProdutos.IndexOf(Busca);

Console.WriteLine($"indice 2: {indice}");

Busca.Nome = "Blusa corta vento da adidas";

listaProdutos.RemoveAt(indice);

listaProdutos.Insert(indice, Busca);

//produtos depois da alteracao
foreach (var item in listaProdutos)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Codigo: {item.Codigo}, Nome: {item.Nome}, Preco: {item.Preco:C} {listaProdutos.IndexOf(item)}");
    Console.ResetColor();
}


Console.Beep(1000,1000);