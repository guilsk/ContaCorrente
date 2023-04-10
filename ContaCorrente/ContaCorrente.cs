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
        public Movimentacao[] movimentacao;

        public ContaCorrente(int numero, double saldo, bool isSpecial, double limite, Movimentacao[] movimentacao)
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
            if (valor <= this.limite + this.saldo)
            {
                this.saldo -= valor;

                Movimentacao m = new Movimentacao();
                m.valor = valor;
                m.tipo = "Débito";
                m.descricao = "Débito de "+valor+" reais";
                this.movimentacao[PegaPosicaoVazia()] = m;
            }
            
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
            Movimentacao m = new Movimentacao();
            m.valor = valor;
            m.tipo = "Crédito";
            m.descricao = "Crédito de " + valor + " reais";
            this.movimentacao[PegaPosicaoVazia()] = m;
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
            Console.WriteLine("Movimentação: ");
            for (int i = 0; i < this.movimentacao.Length; i++)
            {
                if (this.movimentacao[i] != null)
                {
                    Console.Write(" -> ");
                    this.movimentacao[i].Informacoes(); 
                }
            }
        }

        public void TransferirPara(ContaCorrente c, double valor)
        {
            Sacar(valor);
            c.Depositar(valor);
        }

        public int PegaPosicaoVazia()
        {
            int n = 0;
            for (int i = 0; i < this.movimentacao.Length; i++)
                if (this.movimentacao[i] == null)
                    n = i;
            
            return n;
        }
    }
}