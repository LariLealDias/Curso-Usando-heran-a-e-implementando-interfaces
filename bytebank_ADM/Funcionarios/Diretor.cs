using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{                        //herdando um classe, como esta no mesmo assembly não precisa importar o namespace
                         //Diretor é um funcionario, por isso a mãe será Funcionario, sendo esta uma classe mais
                         //generica
    public class Diretor : FuncionarioAutenticavel
    {
        ////Como a classe Diretor herda de Funcionarios
        ////isso significa que pode retirar as autopropertys comentadas abaixo
        ////pois já estão herdando de Funcionario
        //public string Nome { get; set; }
        //public string Cpf { get; set; }
        //public double Salario { get; set; }


        public override double GetBonificacao()
        {
            //pegar 100% + 10% dele
            //return this.Salario + (base.GetBonificacao());
            //base é para se certificar de que esta pegando de fato o metodo
            //da class mãe e não confundir com a o metodo da class filha
            //porém desta forma, nao fica tao legivel necessariamente oq é
            return this.Salario += 0.1;

        }

        //Antes
        //public Diretor(string cpf, double salario) : base(cpf, salario)
        //Sobre a variavel salario
        //como já vai ser passada nesse momento, não precisa declarar a variavel na filha
        //apenas colocar o valor na mãe
        //Depois
        public Diretor(string cpf) : base(cpf, 5000)
        {
            //Console.WriteLine("Criadno Diretor");

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }




        //implementação do login
        //porém nao faz muito sentido continuar aqui se existe uma class abstract
        //public string Senha { get; set; }
        //public bool Autenticar(string senha)
        //{
        //    return this.Senha == senha;
        //}

        //por ser abstract, precisa implementar na class que herdou

        //resolução do VS:
        //public string Senha { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string Login { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public bool Autenticar(string senha, string login)
        //{
        //    return this.Senha == senha && this.Login == login;
        //}
    }
}
