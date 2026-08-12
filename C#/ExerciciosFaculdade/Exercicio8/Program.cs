// Programa que informa o troco de um compra
Console.WriteLine("Informe qual o valor da compra:");
double valor = double.Parse((Console.ReadLine()));
Console.WriteLine("Informe quanto de dinheiro foi dado para o pagamento");
double dinheiro_dado = double.Parse(Console.ReadLine());
if (dinheiro_dado >= valor)
{
    double troco = dinheiro_dado - valor;
    Console.WriteLine("O troco é: " + troco);
}
else
{
    Console.WriteLine("Dinheiro insuficiente.");
}