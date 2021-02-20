using System;

namespace ByteBank.Funcionarios
{
	public abstract class Funcionario
	{
		public static int TotalDeFuncionarios { get; private set; }
		public string Nome { get; set; }
		public string CPF { get; private set; }
		public double Salario { get; protected set; }

		public Funcionario(double salario, string cpf)
		{
			CPF = cpf;
			Salario = salario;
		}

		public virtual double GetBonificacao()
		{
			return Salario * 0.10;
		}

		public virtual void AumentarSalario()
		{
			Salario *= 1.1;
		}

	}
}