Console.WriteLine("Digite o valor da média de vendas mensal do produto:");
double mediaMensal = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o preço atual do produto:");
double precoAtual = double.Parse(Console.ReadLine());

if (mediaMensal < 500 && precoAtual < 30)
{
    double acrescimo = 0.10;
    precoAtual = ((precoAtual * acrescimo) + precoAtual);

    Console.WriteLine($"O preço atual é R$ {precoAtual}");
}
else
{
    double reducao = 0.20;
    precoAtual = precoAtual - (precoAtual * reducao);

    Console.WriteLine($"O preço atual é R$ {precoAtual}");
}