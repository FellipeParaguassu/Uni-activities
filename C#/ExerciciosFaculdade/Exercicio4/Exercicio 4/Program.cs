//Conversor Celsius para Fahreinheit
Console.WriteLine("Sistema de Celsius para Fahrenheit \nQuantos graus Celsius?");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = (celsius * 9/5) + 32;
Console.WriteLine($"{celsius:F2} graus Celsius equivalem a {fahrenheit:F2} graus Fahrenheit.");
