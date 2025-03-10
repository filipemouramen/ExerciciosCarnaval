double s = 0;
int a = 3;
int b = 2;

while (b <= 50)
{
    s += a / b;
    a += 2;
    b++;
}

Console.WriteLine(s.ToString("F2"));