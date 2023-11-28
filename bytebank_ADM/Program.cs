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



pedro.AumentarSalario();
roberta.AumentarSalario();
Console.WriteLine("Novo salário do Pedro :" + pedro.Salario);
Console.WriteLine("Novo salário do Roberta :" + roberta.Salario);


Designer otavio = new Designer("23564512-8", 1);
otavio.Nome = "Otavio Batista";
Console.WriteLine(otavio.Nome);
Console.WriteLine(otavio.GetBonificacao());
Console.WriteLine(otavio.GetPremioSemestral());

gerenciador.Registrar(otavio);
otavio.AumentarSalario();
Console.WriteLine("Novo salário do Otávio :" + otavio.Salario);

GerenteDeContas reginaldo = new GerenteDeContas("3265326532-8", 3999);
reginaldo.Nome = "Reginaldo Baptista";
Console.WriteLine(reginaldo.Nome);
Console.WriteLine(reginaldo.GetBonificacao());
Console.WriteLine(reginaldo.GetPremioSemestral());

gerenciador.Registrar(reginaldo);
reginaldo.AumentarSalario();
Console.WriteLine("Novo salário do Reginaldo :" + reginaldo.Salario);

Auxiliar weverton = new Auxiliar("45214521-8", 3000);
weverton.Nome = "Weverton pai do Thaylon";
Console.WriteLine(weverton.Nome);
Console.WriteLine(weverton.GetBonificacao());
Console.WriteLine(weverton.GetPremioSemestral());

gerenciador.Registrar(weverton);
weverton.AumentarSalario();
Console.WriteLine("Novo salário do Weverton :" + weverton.Salario);



Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);
