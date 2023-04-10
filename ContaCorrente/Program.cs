namespace ContaCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente();
            c1.saldo = 1000;
            c1.numero = 12;
            c1.limite = 0;
            c1.isSpecial = true;
            c1.movimentacao = new Movimentacao[10];

            c1.Sacar(200);
            c1.Depositar(300);
            c1.Depositar(500);
            c1.Sacar(200);

            ContaCorrente c2 = new ContaCorrente();
            c2.saldo = 300;
            c2.numero = 13;
            c2.limite = 0;
            c2.isSpecial = true;
            c2.movimentacao = new Movimentacao[10];

            c1.TransferirPara(c2, 400);
            c1.ExibirExtrato();
        }
    }
}