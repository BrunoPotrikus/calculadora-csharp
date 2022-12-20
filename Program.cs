// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        double num1 = RecebeValor();
        double num2 = RecebeValor();

        Soma(num1, num2);   
        Subtracao(num1, num2);
        Divisao(num1, num2);
    }

    static double RecebeValor()
    {
        Console.WriteLine("Digite um valor");
        double num = double.Parse(Console.ReadLine());

        return num;
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