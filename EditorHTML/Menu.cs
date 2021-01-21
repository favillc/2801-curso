using System;

namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;


            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    Viewer.Show("");
                    break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default:
                    break;
            }
        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("EDITOR HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 => Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 => Abrir arquivo");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 => SAIR");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Opção: ");

        }
        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 30; lines++)
            {
                Console.Write("|");
                for (int j = 0; j <= 30; j++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

        }

    }
}