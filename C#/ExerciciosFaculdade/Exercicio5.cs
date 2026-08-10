//PROGRAMA QUE CALCULA SALÁRIO + HORAS EXTRA
Console.WriteLine("Sua carga horária é de 48 horas semanais, caso queira um aumento, deve trabalhar horas extras!\nMe diga, quanto trabalhou essa semana?");
double horas = double.Parse(Console.ReadLine());
if (horas <= 48)
{
    double salario = horas * 40;
    Console.WriteLine($"Você trabalhou somente {horas} essa semana, logo seu salário é de {salario}R$");
}
else
{
    double salario = horas * 40 + ((horas - 48) * 50);
    Console.WriteLine($"Como você trabalhou {horas}, logo você tem um salario de {salario}R$");
}

    