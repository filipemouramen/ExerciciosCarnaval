int[,] matriz = new int[4, 4];

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine($"Digite {i},{j}");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

int somaCaso1 = 0;
int somaCaso2 = 0;
int somaCaso3 = 0;
int somaCaso4 = 0;

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (i < 2 && j < 2)
        {
            somaCaso1 += matriz[i, j];
        }
        if (i >= 2 && j >= 2)
        {
            somaCaso2 += matriz[i, j];
        }
        if (i > j)
        {
            somaCaso3 += matriz[i, j];
        }
        if (i < j)
        {
            somaCaso4 += matriz[i, j];
        }
    }
}
Console.WriteLine($"Soma do caso 01: {somaCaso1}");
Console.WriteLine($"Soma do caso 02: {somaCaso2}");
Console.WriteLine($"Soma do caso 03: {somaCaso3}");
Console.WriteLine($"Soma do caso 04: {somaCaso4}");