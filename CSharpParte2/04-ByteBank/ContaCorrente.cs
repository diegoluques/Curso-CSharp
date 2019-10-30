
public class ContaCorrente
{
    public string tirular;
    public int agencia;
    public int numero;
    public double saldo = 100.00;

    //Quando retorna um valor, comum chamar de função, mas pode ser chamado de método também
    //bool retorna true ou false
    public bool Sacar(double valor)
    {
        if(this.saldo < valor)
        {
            return false;
        } else
        {
            this.saldo -= valor;
            return true;
        }
    }

    //Quando não retorna um valor, chama-se de método
    //void não retorna nenhum valor
    public void Depositar(double valorDepositado)
    {
        this.saldo += valorDepositado;
    }

}