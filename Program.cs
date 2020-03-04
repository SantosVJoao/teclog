using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static List<Pessoas> pessoas = new List<Pessoas>();
        static List<Nb> notebooks = new List<Nb>();
        private static int ram;

        static void Main(string[] args)
        {
            var tecla = ConsoleKey.A;

            while (tecla != ConsoleKey.Escape)
            {
                PrintaMenu();

                tecla = Console.ReadKey().Key;

                Console.WriteLine();
                ValidaOpcoes(tecla);

                Console.WriteLine();
                Console.WriteLine("O que deseja fazer?\nEsc - Sair\nEnter - Voltar ao Menu");
                tecla = Console.ReadKey().Key;
            }
        }

        private static void ValidaOpcoes(ConsoleKey tecla)
        {
            Console.Clear();
            switch (tecla)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Listar Pessoas");
                    ListarPessoas();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Cadastrar Pessoas");
                    CadastrarPessoa();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Listar Notebooks");
                    ListarNotebooks();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("Cadastrar Notebooks");
                    CadastarNotebooks();
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine("Alterar cadastro de pessoas");
                    AlterarCadastroDePessoas();
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine("Exclusão do cadastro de Pessoas");
                    ExclusaoDePessoas();
                    break;
                default:
                    Console.WriteLine("Por favor, escolha uma opção válida");
                    break;
            }
        }

        private static void AlterarCadastroDePessoas()
        {
            var codigo = 0;
            ListarPessoas();
            Console.WriteLine("Digite o Codigo que deseja alterar");
            var codigoDigitado = Console.ReadLine();
            int.TryParse(codigoDigitado, out codigo);
            var p = pessoas.Where(w => w.Codigo == codigo).FirstOrDefault();

            if (p == null)
            {
                Console.WriteLine("Codigo não encontrado");
            }
            else
            {
                var nome = "";
                while (string.)





            }

        }

        private static void ExclusaoDePessoas()
        {
            
        }

        private static void CadastarNotebooks()
        {
            Console.WriteLine("Digite a Marca do notebook:");
            var Marca = Console.ReadLine();
            Console.WriteLine("Digite a Quantidade de RAM do seu Notebook:");
            var QuantidadeRam = Console.ReadLine();

            int.TryParse(QuantidadeRam, out ram);

            Console.WriteLine("Digite Placa de video");
            var PlacaDeVideo = Console.ReadLine();

            var n = new Nb(notebooks.Count, Marca, ram, PlacaDeVideo);
            notebooks.Add(n);
        }

        private static void ListarNotebooks()
        {
            if (notebooks.Count == 0)
            {
                Console.WriteLine("Não existem notebooks cadastrados.");
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------------");
                foreach (var Nb in notebooks)
                {
                    Console.WriteLine($"Codigo: {Nb.Codigo}");
                    Console.WriteLine($"Marca: {Nb.Marca}");
                    Console.WriteLine($"QuantidadeRam: {Nb.QtdRam}");
                    Console.WriteLine($"Placa de Video: {Nb.placadevideo}");
                    Console.WriteLine("---------------------------------------------------------------");
                }
            }
        }

        private static void CadastrarPessoa()
        {
            Console.WriteLine("Digite o Nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o Idade: ");
            var idade = 0;
            try
            {
                idade = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                idade = 18;
            }
            var p = new Pessoas(pessoas.Count, nome, idade);
            pessoas.Add(p);
        }

        private static void ListarPessoas()
        {
            if (pessoas.Count == 0)
            {
                Console.WriteLine("Não existem registros de pessoas.");
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------------");
                foreach (var pessoa in pessoas)
                {
                    Console.WriteLine($"Codigo: {pessoa.Codigo}");
                    Console.WriteLine($"Nome: {pessoa.Nome}");
                    Console.WriteLine($"Idade: {pessoa.Idade}");
                    Console.WriteLine("---------------------------------------------------------------");
                }
            }
        }

        static void PrintaMenu()
        {
            #region Opcoes
            Console.WriteLine("Bem vindo ao nosso sistema!");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1-Listar Pessoas:");
            Console.WriteLine("2-Cadastrar de Pessoa");
            Console.WriteLine("3-Listar Notebooks");
            Console.WriteLine("4-Cadastrar Notebooks");
            Console.WriteLine("5-Alterar Pessoa");
            Console.WriteLine("6-Excluir Pessoa");
            #endregion
        }
    }
}
