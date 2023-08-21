// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("bhaskara");
int a, b, c;
double x1, x2, delta;

Console.WriteLine("Digite o Valor de A:");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o Valor de B:");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o Valor de C:");
c = int.Parse(Console.ReadLine());

delta = Math.Pow(b, 2) - 4 * a * c;
delta = Math.Sqrt(delta);

x1 = ((-b) + delta) / (2 * a);
x2 = ((-b) - delta) / (2 * a);

if (delta < 0)
{
    Console.WriteLine("Não há resultado possível");
}
else
{
    Console.WriteLine("X1:" + x1 + "\n X2:" + x2);
}