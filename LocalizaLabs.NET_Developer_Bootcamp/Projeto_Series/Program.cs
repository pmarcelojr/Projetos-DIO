using System;
using Projeto_Series.Controller;
using Projeto_Series.View;

namespace Projeto_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string opcaoUsuario = Tela.Menu();
            SerieController ctr = new SerieController();

            while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ctr.ListarSeries();
						break;
					case "2":
						ctr.InserirSerie();
						break;
					case "3":
						ctr.AtualizarSerie();
						break;
					case "4":
						ctr.ExcluirSerie();
						break;
					case "5":
						ctr.VisualizarSerie();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = Tela.Menu();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
        }
    }
}
