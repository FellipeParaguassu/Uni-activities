//Cálculo de IMC usando altura e peso usando double para arredondar
Console.WriteLine("Qual seu peso?");
double peso = double.Parse(Console.ReadLine());
Console.WriteLine("Qual sua Altura?");
double altura = double.Parse(Console.ReadLine());
double IMC = peso / (altura * altura);
Console.WriteLine($"Se sua altura é {altura} e seu peso é {peso}, então seu IMC é {IMC:F2}");