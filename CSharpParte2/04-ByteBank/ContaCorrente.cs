
public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100.00;

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