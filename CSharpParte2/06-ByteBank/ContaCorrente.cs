
namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100.00;

        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }
            this.saldo = saldo;
        }

        public double ObterSaldo()
        {
            return this.saldo;
        }

        //Quando retorna um valor, comum chamar de função, mas pode ser chamado de método também
        //bool retorna true ou false
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            return true;
        }

        //Quando não retorna um valor, chama-se de método
        //void não retorna nenhum valor
        public void Depositar(double valorDepositado)
        {
            this.saldo += valorDepositado;
        }

        public bool Transferir(double valorTransferencia, ContaCorrente contaDestino)
        {
            if (this.saldo < valorTransferencia)
            {
                return false;
            }
            this.saldo -= valorTransferencia;
            contaDestino.Depositar(valorTransferencia);
            return true;
        }

    }
}
