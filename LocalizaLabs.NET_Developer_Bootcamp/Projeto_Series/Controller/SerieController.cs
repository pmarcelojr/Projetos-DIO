using System;
using Projeto_Series.Entities;
using Projeto_Series.Entities.Enum;

namespace Projeto_Series.Controller
{
    public class SerieController
    {
        private SerieRepositorio repositorio = new SerieRepositorio();

        public void ListarSeries()
        {
            Console.Clear();
            Console.WriteLine("Listar séries");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                Console.WriteLine();
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.RetornaExcluido();

                Console.WriteLine($"#ID {serie.RetornaId()}: - {serie.RetornaTitulo()} {(excluido ? "*Excluido*" : "")}");
            }
            Console.WriteLine();
        }

        public void InserirSerie()
        {
            Console.Clear();
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.Write("Digite o Genêro entre as opções acima: ");
            int genero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Série: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Digite o Descrição da Série: ");
            string descricao = Console.ReadLine();

            Serie novaSerie = new Serie(repositorio.ProximoId(), (Genero)genero, titulo, descricao, ano);

            repositorio.Insere(novaSerie);
            Console.WriteLine();
            Console.WriteLine($"Serie {titulo} cadastrada com sucesso !");
            Console.Clear();
        }

        public void AtualizarSerie()
        {
            Console.Clear();
            Console.WriteLine("Atualizar série");
            Console.Write("Digite o id da série: ");
            int idSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.Write("Digite o Genêro entre as opções acima: ");
            int genero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Série: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Digite o Descrição da Série: ");
            string descricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(idSerie, (Genero)genero, titulo, descricao, ano);

            repositorio.Atualiza(idSerie, atualizaSerie);
            Console.WriteLine();
            Console.WriteLine($"Serie {titulo} atualizada com sucesso !");
        }

        public void ExcluirSerie()
        {
            Console.Clear();
            Console.WriteLine("Excluir série");
            try
            {
                Console.Write("Digite o id da série: ");
                int idSerie = int.Parse(Console.ReadLine());

                Console.WriteLine($"Você tem deseja excluir a Série:\n{repositorio.RetornaPorId(idSerie)}");
                Console.Write("(S/N): ");
                string resp = Console.ReadLine();
                if (resp == "S" || resp == "s")
                {
                    repositorio.Excluir(idSerie);
                    Console.WriteLine("Série excluida com sucesso!");
                }

                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Nenhuma serie para Excluir!");
                Console.WriteLine();
            }
        }

        public void VisualizarSerie()
        {
            Console.Clear();
            Console.WriteLine("Visualizar Série");
            try
            {
                Console.Write("Digite o id da série: ");
                int idSerie = int.Parse(Console.ReadLine());

                Console.WriteLine();
                var serie = repositorio.RetornaPorId(idSerie);
                Console.WriteLine(serie);
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Nenhuma serie para Visualizar!");
                Console.WriteLine();
            }
        }
    }
}