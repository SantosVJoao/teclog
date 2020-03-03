using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tecla = ConsoleKey.A;
            var Pessoas = new List<Pessoas>();
            var Notebooks = new List<notebooks>();

            while (tecla != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now.ToString(), CultureInfo.CurrentCulture);
                PrintaMenu();
                tecla = Console.ReadKey().Key;
                
                PrintaMenu();

                switch (tecla)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\nCadastrar pessoas");
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\nCadastrar Notebooks");
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("\nListar pessoas");
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("\nListar Notebooks");
                        break;

                    default:
                        Console.WriteLine("\nSelecione uma opção valida");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("O que deseja fazer?\nEsc = Sair do sistema\nEnter = Voltar ao Menu");
                tecla = Console.ReadKey().Key;
            }

        }
        static void PrintaMenu()
        {
            Console.WriteLine("Bem vindo ao nosso sistema!");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1-Cadastro de Pessoa");
            Console.WriteLine("2-Cadastro de Notebook");
            Console.WriteLine("3-Listar Notebooks");
            Console.WriteLine("4-Listar Pessoas");
        }
    }
}