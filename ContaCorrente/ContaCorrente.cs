using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class ContaCorrente
    {
        public int numero;
        public double saldo;
        public bool isSpecial;
        public double limite;
        public string[] movimentacao;

        public ContaCorrente(int numero, double saldo, bool isSpecial, double limite, string[] movimentacao)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.isSpecial = isSpecial;
            this.limite = limite;
            this.movimentacao = movimentacao;
        }

        public ContaCorrente()
        {
        }

        public void Sacar(double valor)
        {
            if(valor <= this.limite + this.saldo) this.saldo -= valor;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo: " + this.saldo);
        }

        public void ExibirExtrato()
        {
            Console.WriteLine("Número: " + this.numero);
            Console.WriteLine("Saldo: " + this.saldo);
            Console.WriteLine("Conta Especial: " + this.isSpecial);
            Console.WriteLine("Limite: " + this.limite);
            Console.WriteLine("Movimentação:");
            for (int i = 0; i < this.movimentacao.Length; i++){
                if(i % 2 == 0)
                    movimentacao[i] = "credito";
                else
                    movimentacao[i] = "débito";
                Console.WriteLine("\t" + this.movimentacao[i]);
            }
        }

        public void TransferirPara(ContaCorrente c, double valor)
        {
            c.saldo += valor;
        }
    }
}