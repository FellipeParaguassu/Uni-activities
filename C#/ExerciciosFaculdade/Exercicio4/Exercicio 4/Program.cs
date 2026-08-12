//Programa que calcula a média de gasolina gasta com base na distância percorrida e no consumo do veículo.
Console.WriteLine("Digite a distância percorrida em quilômetros:");
double distancia = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o consumo do veículo em quilômetros por litro:");
double consumo = double.Parse(Console.ReadLine());
double mediaGasolina = distancia / consumo;
Console.WriteLine($"A média de gasolina gasta é de {mediaGasolina:F2} litros.");