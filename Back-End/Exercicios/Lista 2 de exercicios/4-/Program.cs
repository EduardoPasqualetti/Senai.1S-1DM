

char sexo;
char gostouDoProduto;

int totalSim = 0;
int totalNao = 0;

int totalMulherSim = 0;
int totalHomemNao = 0;

int totalMulher = 0;
int totalHomem = 0;


double porcentagemHomemNao = 0;


for (var i = 1; i <= 3; i++)
{
 Console.WriteLine(@$"
 Digite o sexo da pessoa:
 (m)- Masculino 
 (f) Feminino 
 ");

 sexo = char.Parse(Console.ReadLine().ToLower());

if (sexo == 'f')
{
    totalMulher++;
}
else 
{
    totalHomem++;
}

Console.WriteLine(@$"
A pessoa gostou do produto lancado ?
(s) - Sim
(n) - Nao
");

gostouDoProduto = char.Parse(Console.ReadLine().ToLower());

if (gostouDoProduto == 's')
{
    totalSim++;

    if (sexo == 'f')
    {
        totalMulherSim++;
    }

}
else
{
    totalNao++;

    if (sexo == 'm')
    {
        totalHomemNao++;
    }
}
}

porcentagemHomemNao = Math.Round(((double)totalHomem / (double)totalHomem) * 100  ,2);




Console.WriteLine($"O total de pessoas que responderam sim foi de : {totalSim}");

Console.WriteLine($"O total de pessoas que responderam nao foi de : {totalNao}");

Console.WriteLine($"O total de mulheres que responderam sim foi de : {totalMulherSim}");

Console.WriteLine($"A porcentagem de homens que responderam nao foi de : {porcentagemHomemNao}%");