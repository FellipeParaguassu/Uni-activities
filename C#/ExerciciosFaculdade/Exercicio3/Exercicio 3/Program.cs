// Leitor de média
float soma = 0f;// O "f" transforma o zero em tipo float
Console.WriteLine($"Programa de leitura de média");
for (int i = 1; i < 4; i++)
{
    Console.WriteLine($"Indique a nota {i}");
    float nota;
    while (!float.TryParse(Console.ReadLine(), out nota))//Tenta converter a tring pra float, se der certo manda pelo out, senão repete
    {
        Console.WriteLine("Entrada inválida. Digite a nota novamente:");
    }
    soma += nota;//Contador (acumulador) 
}
float media = soma / 3f;//O mesmo acontece com o 3, vira float
Console.WriteLine($"Sua média final é {media:F2}");