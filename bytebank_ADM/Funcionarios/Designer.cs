using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000) //como ja sabe o valor, pode passar ao inves da variavel
        {

        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
