namespace ByteBank.Modelos
{
	public class ParceiroComercial : IAutenticavel
	{
		private AutenticacaoHelper autenticacaoHelper = new AutenticacaoHelper();

		public string Senha { get; set; }

		public bool Autenticar(string senha)
		{
			return autenticacaoHelper.CompararSenha(Senha, senha);
		}
	}
}