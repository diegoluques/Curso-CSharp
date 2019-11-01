using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        // 0 - Funcionario
        // 1 - Diretor
        // 2 - Designer
        // N - ...
        private int _tipoFuncionario;

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(int tipo)
        {
            _tipoFuncionario = tipo;
        }

        public double GetBonificacao()
        {
            if (_tipoFuncionario == 0)
                return Salario;

            return Salario * 0.10;
        }
    }
}
