using System;

namespace ByteBank.SistemaAgencia
{
	public class ExtratorValorDeArgumentosUrl
	{
		private readonly string _argumentos;
		public string Url { get; }

		public ExtratorValorDeArgumentosUrl(string url)
		{
			if (string.IsNullOrEmpty(url))
				throw new ArgumentException("O argumento url não pode ser nulo ou vazio.", nameof(url));

			int indiceInterrogacao = url.IndexOf('?');
			_argumentos = url.Substring(indiceInterrogacao + 1);

			Url = url;
		}

		public string ObterValoresDosAgumentos(string nomeDoParametro)
		{
			nomeDoParametro = nomeDoParametro.ToUpper();
			string argumentoToUpper = _argumentos.ToUpper();

			string termo = nomeDoParametro + "=";
			int indiceParametro = argumentoToUpper.IndexOf(termo);

			string resultado = _argumentos.Substring(indiceParametro + termo.Length);
			int indiceEcomercial = resultado.IndexOf('&');

			if (indiceEcomercial == -1)
				return resultado;

			return resultado.Remove(indiceEcomercial);
		}
	}
}