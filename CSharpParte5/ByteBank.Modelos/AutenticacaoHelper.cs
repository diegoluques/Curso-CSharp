namespace ByteBank.Modelos
{
	public class AutenticacaoHelper
	{
		internal bool CompararSenha(string senha, string senhaTentativa)
		{
			return (senha == senhaTentativa);
		}
	}
}