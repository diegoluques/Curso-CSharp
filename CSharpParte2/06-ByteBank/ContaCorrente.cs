
namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; } 
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100.00;

        public double Saldo
        {
            get
            {
                return this._saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                this._saldo = value;
            }
        }

        //Quando retorna um valor, comum chamar de função, mas pode ser chamado de método também
        //bool retorna true ou false
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            return true;
        }

        //Quando não retorna um valor, chama-se de método
        //void não retorna nenhum valor
        public void Depositar(double valorDepositado)
        {
            this._saldo += valorDepositado;
        }

        public bool Transferir(double valorTransferencia, ContaCorrente contaDestino)
        {
            if (this._saldo < valorTransferencia)
            {
                return false;
            }
            this._saldo -= valorTransferencia;
            contaDestino.Depositar(valorTransferencia);
            return true;
        }

    }
}
