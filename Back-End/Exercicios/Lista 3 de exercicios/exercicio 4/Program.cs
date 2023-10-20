int[] valores = new int[10];
int maior = 0;
int menor = 0;      



for (int i = 0; i < 10; i++) 
{
Console.WriteLine($"Digite o {i +1}° valor:");
valores[i] = int.Parse(Console.ReadLine());
     
if (i == 0)
{
    maior = valores[i];
    menor = valores[i];
} else{

if (valores[i] > maior) {
     maior = valores[i];
}

if (valores[i] < menor) {
    menor = valores[i];
}
}
}
        
Console.WriteLine("Maior valor: " + maior);
Console.WriteLine("Menor valor: " + menor);