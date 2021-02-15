using System;

namespace ByteBank.Funcionarios
{
	public class Diretor : Funcionario
	{
		public Diretor(double salario, string cpf) : base(salario, cpf)
		{
			Console.WriteLine("Criando um Diretor");
		}

		public override void AumentarSalario()
		{
			Salario *= 1.15;
		}

		public override double GetBonificacao()
		{
			return Salario + base.GetBonificacao();
		}
	}
}