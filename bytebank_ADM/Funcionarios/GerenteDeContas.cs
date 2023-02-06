using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        //public string Senha { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string Login { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public GerenteDeContas(string cpf) : base(cpf, 4000) //como ja sabe o valor, pode passar ao inves da variavel
        {

        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.5;
        }



        //public string Senha { get; set; }
        //public bool Autenticar(string senha)
        //{
        //    return this.Senha == senha;
        //}

        //public bool Autenticar(string senha, string login)
        //{
        //    return this.Senha == senha && this.Login == login;

        //}
    }
}
