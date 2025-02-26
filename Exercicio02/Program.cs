Console.WriteLine("Digite a sua altura:");
double altura = double.Parse(Console.ReadLine());

string sexo;
bool entradaCerta = false;

do
{
    Console.WriteLine("Digite o seu sexo (M para masculino e F para feminino):");
    sexo = Console.ReadLine().ToUpper();

    if (sexo == "M")
    {
        double pesoIdeal = (72.7 * altura) - 58;
        Console.WriteLine("O seu peso ideal é: " + pesoIdeal.ToString("F2"));
        entradaCerta = true;
    }
    else if (sexo == "F")
    {
        double pesoIdeal = (62.1 * altura) - 44.7;
        Console.WriteLine("O seu peso ideal é: " + pesoIdeal.ToString("F2"));
        entradaCerta = true;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Digite F ou M!");
    }
} while (!entradaCerta);
