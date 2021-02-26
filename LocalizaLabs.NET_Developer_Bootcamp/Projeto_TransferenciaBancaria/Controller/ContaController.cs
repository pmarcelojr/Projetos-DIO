using System;
using System.Collections.Generic;
using System.Globalization;
using Projeto_TransferenciaBancaria.Classes;
using Projeto_TransferenciaBancaria.Enum;

namespace Projeto_TransferenciaBancaria.Controller
{
    public class ContaController
    {
        List<Conta> listConta = new List<Conta>();
        public void InserirConta()
        {
            Console.Clear();
            Console.WriteLine("Inserir nova Conta");

            Console.Write("Digite 1 para Conta Fisica ou 2 para Juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o nome do Cliente: ");
            string entradaNome = Console.ReadLine();
            
            Console.Write("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta novaConta = new Conta((TipoConta)entradaTipoConta, entradaSaldo, entradaCredito, entradaNome);

            listConta.Add(novaConta);
            Console.WriteLine($"{entradaNome} sua Conta foi cadastrada com sucesso!");
            Console.WriteLine();
        }

        public void ListarContas()
        {
            Console.Clear();
            Console.WriteLine("Listar Contas");

            if (listConta.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; i < listConta.Count; i++)
            {
                Conta conta = listConta[i];
                Console.Write($"#{i} - ");
                Console.WriteLine(conta);
            }
        }

        public void Sacar()
        {
            Console.Clear();
            Console.WriteLine("Sacar");

            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listConta[indiceConta].Sacar(valorSaque);
            Console.WriteLine();
        }

        public void Depositar()
        {
            Console.Clear();
            Console.WriteLine("Depositar");

            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listConta[indiceConta].Depositar(valorDeposito);
            Console.WriteLine();
        }

        public void Transferir()
        {
            Console.Clear();
            Console.WriteLine("Transferir");

            Console.Write("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listConta[indiceContaOrigem].Transferir(valorTransferencia, listConta[indiceContaDestino]);
            Console.WriteLine();
        }
    }
}