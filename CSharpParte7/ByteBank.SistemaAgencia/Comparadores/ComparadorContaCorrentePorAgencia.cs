using ByteBank.Modelos;
using System.Collections.Generic;

namespace ByteBank.SistemaAgencia.Comparadores
{
	public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
	{
		public int Compare(ContaCorrente x, ContaCorrente y) => (x.Agencia.CompareTo(y.Agencia));
	}
}