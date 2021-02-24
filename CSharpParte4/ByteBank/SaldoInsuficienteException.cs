using System;

namespace ByteBank
{
	public class SaldoInsuficienteException : OperacaoFinanceiraException
	{
		public double Saldo { get; }
		public double ValorDoSaque { get; }

		public SaldoInsuficienteException()
		{
		}

		public SaldoInsuficienteException(double saldo, double valorDoSaque)
			: this("Tentativa de saque no valor de R$ " + valorDoSaque + " em uma conta com saldo disponível de: R$ " + saldo)
		{
			Saldo = saldo;
			ValorDoSaque = valorDoSaque;
		}

		public SaldoInsuficienteException(string mensagem) : base(mensagem)
		{
		}

		protected SaldoInsuficienteException(string mensagem, Exception excessaoInterna) : base(mensagem, excessaoInterna)
		{
		}
	}
}