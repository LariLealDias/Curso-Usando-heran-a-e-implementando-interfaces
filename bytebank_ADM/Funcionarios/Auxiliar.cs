using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        //Pq o parametro salario foi passada apenas para a base e não tbm adicionada ao parametro da auxiliar como feito com o Diretor?
       public Auxiliar(string cpf) : base(cpf,2000) //como ja sabe o valor, pode passar ao inves da variavel
       {

       }

        public override double GetBonificacao()
        {
            return this.Salario * 0.2;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1; 
        }
    }
}
