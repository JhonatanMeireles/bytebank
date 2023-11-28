using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario pedro = new Funcionario("123456789-1",2000);
pedro.Nome = "Pedro Sampaio";

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());
Console.WriteLine(pedro.GetPremioSemestral());


Diretor roberta = new Diretor("987654321-9", 5000);
roberta.Nome = "Roberta Silva";

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());
Console.WriteLine(roberta.GetPremioSemestral());


GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);



Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);

Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

pedro.AumentarSalario();
roberta.AumentarSalario();
Console.WriteLine("Novo salário do Pedro :" + pedro.Salario);

Console.WriteLine("Novo salário do Roberta :" + roberta.Salario);
