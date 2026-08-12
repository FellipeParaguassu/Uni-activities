//Programa que calcula o valor de uma prestação com juros simples.
Console.WriteLine("Esse programa fará a leitura de uma prestação e calculará os juros simples, em seguida insira os dadoas solicitados\nInsira o capital inicial:");
double capital = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a taxa de juros (em %):");
double taxa_juros = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o tempo (em meses):");
double tempo = double.Parse(Console.ReadLine());
double juros = capital * (taxa_juros / 100) * tempo;
double montante = capital + juros;
Console.WriteLine($"Se o capital inicial for {capital}, a taxa de juros for {taxa_juros}% e o tempo for {tempo} meses, o valor dos juros será {juros} e o montante será {montante}");
