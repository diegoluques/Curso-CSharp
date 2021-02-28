﻿namespace ByteBank.Modelos.Funcionarios
{
	public class Desenvolvedor : Funcionario
	{
		public Desenvolvedor(string cpf) : base(3000, cpf)
		{
		}

		public override void AumentarSalario()
		{
			Salario *= 0.15;
		}

		internal protected override double GetBonificacao()
		{
			return Salario * 0.1;
		}
	}
}