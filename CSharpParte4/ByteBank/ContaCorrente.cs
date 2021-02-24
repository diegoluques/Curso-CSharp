using System;

namespace ByteBank
{
	public class ContaCorrente
	{
		public Cliente Titular { get; set; }

		public static int TotalDeContasCriadas { get; private set; }

		public int Agencia { get; }

		public int Numero { get; }

		private double _saldo = 0;

		public ContaCorrente(int agencia, int numero)
		{
			if (agencia <= 0)
				throw new ArgumentException("Atenção! Agência deve ser maior que zero", nameof(agencia));

			if (numero <= 0)
				throw new ArgumentException("Atenção! Número deve ser maior que zero", nameof(numero));

			Agencia = agencia;
			Numero = numero;

			TotalDeContasCriadas++;
		}

		public double Saldo
		{
			get
			{
				return _saldo;
			}
			set
			{
				if (value < 0)
				{
					return;
				}

				_saldo = value;
			}
		}

		public void Sacar(double valor)
		{
			if (valor < 0)
				throw new ArgumentException("Ops! Valor do saque não pode ser menor que 0.", nameof(valor));

			if (_saldo < valor)
				throw new SaldoInsuficienteException(Saldo, valor);

			_saldo -= valor;
		}

		public void Depositar(double valor)
		{
			_saldo += valor;
		}

		public void Transferir(double valor, ContaCorrente contaDestino)
		{
			if (valor < 0)
				throw new ArgumentException("Ops! Valor da transferência não pode ser menor que 0.", nameof(valor));

			Sacar(valor);
			contaDestino.Depositar(valor);
		}
	}
}