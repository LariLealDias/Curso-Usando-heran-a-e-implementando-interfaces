using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
                                    //private é apenas disponivel nesta
                                    //classe e não nas que herdam dela !!!
                                    //por isso agora a prop Salario é protected
        public double teste { get; set; }
        public static int TotalDeFuncionarios { get; private set; }


        //comportameto: o bytebank bonifica o funcionario em 0.10%
        //é um Get pois quer retornar 10% do salario

        //Apos ter implementado a herança no Diretor, o GetBonificacao() da classe Diretor não 
        //retorna o esperando(retornar 100% do salario), pois ele esta pegando o metodo da onde herdou
        //para resolver esse conflito é utilizado  o overrider e 
        public abstract double GetBonificacao();
        //{
        //    return this.Salario * 0.10;
        //}

        public Funcionario(string cpf, double salario) //constructo nao precisa ser abstracr
        {   
            this.Cpf = cpf;
            this.Salario = salario;
            
            
            //toda hora que ser instanciado um novo objto terá um ++ no toalfuncionarios
            TotalDeFuncionarios++;

            //ver a ordem de execução da base : filha
            Console.WriteLine("Criadno Funciona");
        }



    ////Comportamnetos
    public abstract void AumentarSalario();
        //{
        //    this.Salario = this.Salario + (this.Salario  * 0.1);
        //}

        //public string Senha { get; set; }
        //public bool Autenticar(string senha)
        //{
        //    return this.Senha == senha;
        //}

    }
}
