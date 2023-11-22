﻿using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Sampaio";
pedro.Cpf = "123456789-1";
pedro.Salario = 2000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());
Console.WriteLine(pedro.GetPremioSemestral());


Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "987654321-9";
roberta.Salario = 5000;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());
Console.WriteLine(roberta.GetPremioSemestral());


GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);




Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);

Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);