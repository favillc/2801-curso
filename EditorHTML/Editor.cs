using System;
using System.IO;
using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("============= ");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(" " + Console.ReadLine());
                file.Append(" " + Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("============= ");
            Console.WriteLine(" Deseja salvar o arquivo[S/N]?:");
            string resp = Console.ReadLine();
            if (resp.Equals("S"))
            {
                Viewer.Show(file.ToString());
                Console.WriteLine(" ");
                Salvar(file.ToString());
            }
            else
            {
                Menu.Show();
            }
            Menu.Show();
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?:");
            string path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo salvo em {path} com sucesso!");
            Menu.Show();
        }
    }
}
