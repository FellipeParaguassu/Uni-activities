//Programa que calcula o desconto aplicado em um produto
Console.WriteLine("Digite o preço do produto que deseja checar:");
double preco = double.Parse(Console.ReadLine());
Console.WriteLine("Digite agora o desconto que deseja aplicar ao produto(em porcentagem):");
double desconto = double.Parse(Console.ReadLine());
double produto_final = preco - (preco * desconto / 100);
Console.WriteLine($"Se o produto custa {preco}R$ e o desconto aplicado é de {desconto}%, o preço final do produto será de {produto_final}R$");