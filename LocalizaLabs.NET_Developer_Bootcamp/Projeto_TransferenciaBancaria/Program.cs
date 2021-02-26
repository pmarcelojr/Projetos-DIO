using System;
using System.Collections.Generic;
using Projeto_TransferenciaBancaria.Classes;
using Projeto_TransferenciaBancaria.Controller;
using Projeto_TransferenciaBancaria.Enum;
using Projeto_TransferenciaBancaria.Tela;

namespace Projeto_TransferenciaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaController conta = new ContaController();

            string opcao = Menu.ObterOpcaoUsuario();

            while (opcao.ToUpper() != "X")
            {
                switch (opcao.ToUpper())
                {
                    case "1":
                        conta.ListarContas();
                        break;
                    case "2":
                        conta.InserirConta();
                        break;
                    case "3":
                        conta.Transferir();
                        break;
                    case "4":
                        conta.Sacar();
                        break;
                    case "5":
                        conta.Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao = Menu.ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            
            Console.WriteLine();
        }
    }
}
