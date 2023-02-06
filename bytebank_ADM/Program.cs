using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("123456789", 2000);
//pedro.Nome = "Pedro malazartes";
////pedro.Cpf = "123456789";
////pedro.Salario = 2000; //vai retornar 10% do salario

//Console.WriteLine("Bonificação de " + pedro.Nome + " => " + pedro.GetBonificacao());



//Diretor roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Silva";
////roberta.Cpf = "987654321";
////roberta.Salario = 5600; //vai retornar 100% do salario

//Console.WriteLine("Bonificação de " + roberta.Nome+ " => " + roberta.GetBonificacao());



//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
//Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine($"Novo salario Pedro {pedro.Salario}");
//Console.WriteLine($"Novo salario roberta {roberta.Salario}");
#endregion

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("987456");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("74581");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("852963");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de Bonificação = " + gerenciador.GetTotalBonificacao());
}

CalcularBonificacao();


//Testando o Login
void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("124567787");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";
    ingrid.Login = "ingrid@.com";

    GerenteDeContas ursula = new GerenteDeContas("963741");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";
    ursula.Login = "ursula@.com";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";
    caio.Login = "caio@";

    sistema.Logar(ingrid, "123", "ingrid@.com");
    sistema.Logar(ursula, "963", "ingrid@.com");
    sistema.Logar(caio, "ee", "sde");
}

UsarSistema();