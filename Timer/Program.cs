﻿using System;
using System.Threading;

namespace Timer
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
            Console.WriteLine("S = segundos => 10s -> 10 segundos ");
            Console.WriteLine("M = minutos => 1m -> 1 minuto");
            Console.WriteLine("X = Sair");
            Console.WriteLine("Preparar o timer para quanto tempo? ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;
            if (type == 'm')
                multiplier = 60;
            if (type == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO!");
            Thread.Sleep(1000);
            Start(time);

        }
        static void Start(int time)
        {
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch Finalizado!");
            Thread.Sleep(2000);
        }
    }
}
