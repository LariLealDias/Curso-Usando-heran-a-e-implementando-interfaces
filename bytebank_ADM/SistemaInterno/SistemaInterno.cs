using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    //essa class é para autenticar usuarios no sistema interno
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha, string login)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha, login);
            if(usuarioAutenticado) 
            {
                Console.WriteLine("Bem vindo");
                return true;
            }

            Console.WriteLine("Alguma informação esta incorreta");
            return false;
        }

        //public bool Logar(ParceiroComercial funcionario, string senha, string login)
        //{
        //    bool usuarioAutenticado = funcionario.Autenticar(senha, login);
        //    if (usuarioAutenticado)
        //    {
        //        Console.WriteLine("Bem vindo");
        //        return true;
        //    }

        //    Console.WriteLine("Alguma informação esta incorreta");
        //    return false;
        //}
    }
}
