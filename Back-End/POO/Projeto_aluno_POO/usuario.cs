namespace Projeto_Aluno
{
    class Aluno {
    public string Nome; 
    public string Curso ;
    public int Idade ;
    public string RG ;
    public bool Bolsista ;
    public double MediaFinal ;
    public double ValorMensalidade ;

    public void VerMediaFinal() {
        Console.WriteLine($"A média final do aluno {Nome} é {MediaFinal}.");
    }

    public void VerMensalidade() {
        if (Bolsista && MediaFinal >= 8) {
            ValorMensalidade = 0.5 * ValorMensalidade;
        }
        else if (Bolsista && MediaFinal >= 6) {
            ValorMensalidade = 0.7 * ValorMensalidade;
        }
        Console.WriteLine($"O valor da mensalidade do aluno {Nome} é {ValorMensalidade}.");
    }
}

}