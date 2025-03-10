int[] D = new int[20];

Console.WriteLine("Digite os 20 elementos do seu vetor:");

for (int i = 0; i < 20; i++)
{
    Console.WriteLine($"Digite o elemento {i + 1}:");
    D[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Digite um número para verificar se os número digitados são maiores do que ele:");
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < 20; i++)
{
    if (D[i] > N)
    {
        Console.WriteLine(D[i]);
    }
}