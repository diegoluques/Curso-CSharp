namespace ByteBank.Modelos
{
	public class Cliente
	{
		public string Nome { get; set; }
		public string CPF { get; set; }
		public string Profissao { get; set; }

		public override bool Equals(object obj)
		{
			if (!(obj is Cliente outroCliente))
				return false;

			return
				Nome == outroCliente.Nome &&
				CPF == outroCliente.CPF &&
				Profissao == outroCliente.Profissao;
		}
	}
}