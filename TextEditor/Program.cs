using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer? ");
            Console.WriteLine("0 => Sair");
            Console.WriteLine("1 => Abrir arquivo");
            Console.WriteLine("2 => Criar novo arquivo");

            short option = short.Parse(Console.ReadLine());

            switch (option){
                case 0:
                    Sair();
                    break;
                case 1:
                    Abrir();
                    break;
                case 2:
                    Editar();
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Abrir(){
             Console.Clear();
             Console.WriteLine("Qual o caminho do arquivo?:");
             string path = Console.ReadLine();

             using(var file = new StreamReader(path)){
                 string text = file.ReadToEnd();
                 Console.Write(text);
             }
             Console.WriteLine("");
             Console.ReadLine();
             Menu();
        }
        static void Editar(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo [ESC para sair]");
            Console.WriteLine("___________________________________________");
            string text = "";
          do{
             text += Console.ReadLine();
             text += Environment.NewLine;
          }while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write(text);
            Salvar(text);
        }

        static void Salvar(string text){
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?:");
            string path = Console.ReadLine();

            using(var file = new StreamWriter(path)){
                file.Write(text);
            }
             
            Console.WriteLine($"Arquivo salvo em {path} com sucesso!");
            Menu();
        }
        static void Sair(){
            Console.Clear();
            Console.WriteLine("Bye Bye!");
            System.Environment.Exit(0);
        }
        static void Main(string[] args)
        {
           Menu();
        }

       
    }
}
