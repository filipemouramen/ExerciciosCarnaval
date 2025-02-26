Console.WriteLine("Digite o número de horas trabalhadas no mês:");
double horasTrabalhadasMes = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do seu salário por hora:");
double salarioHora = double.Parse(Console.ReadLine()); 

double salarioBase = salarioHora * 160;

if (horasTrabalhadasMes > 160)
{
    double horasExtras = horasTrabalhadasMes - 160; 
    double valorHoraExtra = salarioHora * 0.5;
    double salarioTotal = salarioBase + (horasExtras * valorHoraExtra);

    Console.WriteLine("O salário total no mês é de R$ " + salarioTotal.ToString("F2"));
}
else
{
    double salarioTotal = salarioBase; 
    Console.WriteLine("O salário total no mês é de R$ " + salarioTotal.ToString("F2"));
}
