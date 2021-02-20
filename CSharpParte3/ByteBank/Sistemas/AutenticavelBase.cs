namespace ByteBank.Sistemas
{
	public class AutenticavelBase
	{
		public string Senha { get; set; }

		public bool Autenticar(string senha)
		{
			return (Senha == senha);
		}
	}
}