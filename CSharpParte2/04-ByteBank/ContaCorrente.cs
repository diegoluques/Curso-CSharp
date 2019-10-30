
public class ContaCorrente
{
    public string tirular;
    public int agencia;
    public int numero;
    public double saldo = 100.00;


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

}