int[] R = new int[5];

Console.WriteLine("Digite os números que foram sorteados na LOTO:");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o número " + (i + 1) + ":");
    R[i] = int.Parse(Console.ReadLine());
}

int[] A = new int[10];

Console.WriteLine("Digite os números da sua aposta:");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o número " + (i + 1) + ":");
    A[i] = int.Parse(Console.ReadLine());
}

int acertos = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        if (R[i] == A[j])
        {
            acertos++;
            break;
        }
    }
}
Console.WriteLine($"Você acertou {acertos} números!");