using System;
using Projeto_TransferenciaBancaria.Enum;

namespace Projeto_TransferenciaBancaria.Classes
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            TipoConta = tipoConta;
            Saldo = saldo;
            Credito = credito;
            Nome = nome;
        }

        public bool Sacar(double valorSaque)
        {
            // Validação de saldo suficiente
            if (Saldo - valorSaque < (Credito *-1))
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }

            Saldo -= valorSaque;
            Console.WriteLine($"Saldo atual da conta de {Nome} é {Saldo}");
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;
            Console.WriteLine($"Saldo atual da conta de {Nome} é {Saldo}");
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }

        }

        public override string ToString()
        {
            return $"Tipo conta: {TipoConta} | Nome: {Nome} | Saldo: {Saldo} | Crédito: {Credito}";
        }
    }
}