﻿using ScreenSound.Menus;
using ScreenSound.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        Banda ira = new("Ira");

        ira.AdicionarNota(new Avaliacao(10));
        ira.AdicionarNota(new Avaliacao(8));
        ira.AdicionarNota(new Avaliacao(6));

        Banda beatles = new("The Beatles");

        Dictionary<string, Banda> bandasRegistradas = new();
        bandasRegistradas.Add(ira.Nome, ira);
        bandasRegistradas.Add(beatles.Nome, beatles);

        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(1, new MenuRegistrarBanda());
        opcoes.Add(2, new MenuRegistrarAlbum());
        opcoes.Add(3, new MenuMostrarBandas());
        opcoes.Add(4, new MenuAvaliarBanda());
        opcoes.Add(5, new MenuAvaliarAlbum());  
        opcoes.Add(6, new MenuExibirDetalhes());
        opcoes.Add(-1, new MenuSair());

        void ExibirLogo()
        {
            Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
            Console.WriteLine("Boas vindas ao Screen Sound 3.0!");
        }

        void ExibirOpcoesDoMenu()
        {
            
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 avaliar um álbum");
            Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
            {
                Menu menuescolhido = opcoes[opcaoEscolhidaNumerica];
                menuescolhido.Executar(bandasRegistradas);
                if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();

                else
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA");
                }
            }
        }
    ExibirOpcoesDoMenu();
    }
}
