using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
	public class GerenciadorBonificacao
	{
		private double _totalBonificacao;

		public void Registrar(Funcionario funcionario)
		{
			_totalBonificacao += funcionario.GetBonificacao();
		}

		public double GetTotalBonificacao()
		{
			return _totalBonificacao;
		}

		internal static void Registrar()
		{
			throw new NotImplementedException();
		}
	}
}