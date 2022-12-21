// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("Escolha uma operação");
        Console.WriteLine("1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n0 - Sair");
        int opcao = int.Parse(Console.ReadLine());

        RecebeValor(opcao);
    }

    static void RecebeValor(int opcao)
    {
        switch (opcao)
        {
            case 1:
                Soma();
                break;

            case 2:
                Subtracao();
                break;

            case 3:
                Multiplicacao();
                break;

            case 4:
                Divisao();
                break;

            case 0:
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Opção inválida!");
                Menu();
                break;
        }
    }

    static void Soma()
    {
        Console.WriteLine("Digite o primeiro valor");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 + num2;

        Console.WriteLine($"Resultado da soma: {resultado}");

        Menu();
    }

    static void Subtracao()
    {
        Console.WriteLine("Digite o primeiro valor");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 - num2;

        Console.WriteLine($"Resultado da subtração: {resultado}");

        Menu();
    }

    static void Divisao()
    {
        Console.WriteLine("Digite o primeiro valor");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 / num2;

        Console.WriteLine($"Resultado da divisão: {resultado}");

        Menu();
    }

    static void Multiplicacao()
    {
        Console.WriteLine("Digite o primeiro valor");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 *  num2;

        Console.WriteLine($"Resultado da multiplicação: {resultado}");

        Menu();
    }
}