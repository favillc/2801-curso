using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("         M E N U");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair da aplicação");
            Console.WriteLine("_____________________________");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
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
                case 5:
                    Sair();
                    break;
                default:
                    Menu();
                    break;
            }

        }
        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Tchau Tchau!");
            Console.ReadKey();
            System.Environment.Exit(0);

        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("         S O M A ");
            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 1: " + v1);
            Console.WriteLine("Valor 2: " + v2);
            Console.WriteLine(" ");
            double resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("        S U B T R A Ç Ã O");
            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 1: " + v1);
            Console.WriteLine("Valor 2: " + v2);
            Console.WriteLine(" ");
            double resultado = v1 - v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("         M U L T I P L I C A Ç Ã O");
            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 1: " + v1);
            Console.WriteLine("Valor 2: " + v2);
            Console.WriteLine(" ");
            double resultado = v1 * v2;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("         D I V I S Ã O");
            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 1: " + v1);
            Console.WriteLine("Valor 2: " + v2);
            Console.WriteLine(" ");
            double resultado = v1 / v2;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }

}
