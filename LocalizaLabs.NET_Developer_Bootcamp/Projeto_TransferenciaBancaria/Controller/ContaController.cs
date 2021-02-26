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
        }
    }
}