using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class Movimentacao
    {
        public double valor;
        public string tipo;
        public string descricao;

        public Movimentacao()
        {
        }

        public Movimentacao(double valor, string tipo, string descricao)
        {
            this.valor = valor;
            this.tipo = tipo;
            this.descricao = descricao;
        }
        
        public void Informacoes()
        {
            Console.WriteLine(descricao);
        }
    }
}
