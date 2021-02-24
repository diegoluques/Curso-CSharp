using System;
using System.Runtime.Serialization;

namespace ByteBank
{
	public class OperacaoFinanceiraException : Exception
	{
		public OperacaoFinanceiraException()
		{
		}

		public OperacaoFinanceiraException(string mensagem) : base(mensagem)
		{
		}

		protected OperacaoFinanceiraException(string mensagem, Exception excessaoInterna) : base(mensagem, excessaoInterna)
		{
		}
	}
}