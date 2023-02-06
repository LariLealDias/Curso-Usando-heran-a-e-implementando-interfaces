using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        private double TotalDeBonficacao;

        //metodos de registrar tanto funcionario quanto diretor é para incrementar a bonificação
        //metodo Registrar => é para registrar uma bonificação
        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonficacao += funcionario.GetBonificacao();
                                                  //esse metodo só funciona pq ele esta no Funcionario
                                                  //ou seja, é possivel passar classes como tipo e captar seus
                                                  //metodos etc 
        }

        ////A partir da implementação da herança na class Diretor, esta função sobrecarregada
        ////comentada fica obsoleto ou seja, já não tem mais motivo para utiliza-la
        //public void Registrar(Diretor diretor)
        //{
        //    this.TotalDeBonficacao += diretor.GetBonificacao();
        //}

        public double GetTotalBonificacao()
        {
            return this.TotalDeBonficacao;
        }

    }
}
