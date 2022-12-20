// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        RecebeValor();
    }

    static void RecebeValor()
    {
        Console.WriteLine("Digite o primeiro valor");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
        double num2 = double.Parse(Console.ReadLine());

        Soma(num1, num2);
        Subtracao(num1, num2);
        Divisao(num1, num2);
    }

    static void Soma(double num1, double num2)
    {
        double resultado = num1 + num2;

        Console.WriteLine($"Resultado da soma: {resultado}");
    }

    static void Subtracao(double num1, double num2)
    {
        double resultado = num1 - num2;

        Console.WriteLine($"Resultado da subtração: {resultado}");
    }

    static void Divisao(double num1, double num2)
    {
        double resultado = num1 / num2;

        Console.WriteLine($"Resultado da divisão: {resultado}");
    }
}