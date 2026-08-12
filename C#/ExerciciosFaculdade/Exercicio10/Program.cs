//. Programa que lê os dados de um aluno e exibe um boletim simplificado.(Não entendi legal)

double nota = 0;
Console.WriteLine("Este site realizará a leitura de dados de um aluno e exibirá um boletim simplificado.\nInsira o nome do aluno:");
string nome = Console.ReadLine();
Console.WriteLine("Insira a idade do aluno:");
double idade = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a turma do aluno:");
string turma = Console.ReadLine();
for (int i = 0; i<4; i++)
{
    Console.WriteLine($"Insira a nota {i + 1} do aluno:");
    nota += double.Parse(Console.ReadLine());
}
double media = nota / 4;
Console.WriteLine($"\nBoletim do aluno {nome}:");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Turma: {turma}");
Console.WriteLine($"Média: {media:F2}");