using bytebank.Contas;
using bytebank.Titular;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_Agencia = 15;
//contaDoAndre.conta = "1010-x";
//contaDoAndre.saldo = 100;
//Console.WriteLine($"O saldo da conta de {contaDoAndre.titular} é de R$ {contaDoAndre.saldo}.");



//ContaCorrente contaDoAndre2 = new ContaCorrente();
//contaDoAndre2.titular = "André Silva";
//contaDoAndre2.numero_Agencia = 15;
//contaDoAndre2.conta = "1010-x";
//contaDoAndre2.saldo = 100;
//Console.WriteLine($"O saldo da conta de {contaDoAndre2.titular} é de R$ {contaDoAndre2.saldo}.");
//contaDoAndre = contaDoAndre2;

//Console.WriteLine(contaDoAndre==contaDoAndre2);

//contaDoAndre.ExibirInfoConta();
//contaDoAndre2.ExibirInfoConta();
///*
//contaDoAndre.Depositar(100);

// Console.WriteLine($"O saldo da conta de pós-depósito {contaDoAndre.titular} é de R$ {contaDoAndre.saldo}.");

//if (contaDoAndre.Sacar(180) == true)
//{

//    Console.WriteLine($"O saldo da conta de pós-saque {contaDoAndre.titular} é de R$ {contaDoAndre.saldo}.");

//}
//else
//    Console.WriteLine("Saque não autorizado pois excede o limite disponível para saque.");


////Console.WriteLine($"O saldo da conta de pós-saque {contaDoAndre.titular} é de R$ {contaDoAndre.saldo}.");
//*/

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_Agencia = 16;
//contaDaMaria.conta = "1011-x";
//contaDaMaria.saldo = 400;

//Console.WriteLine($"O saldo da conta de {contaDaMaria.titular} é de R$ {contaDaMaria.saldo}.");

//contaDoAndre.transferir(80, contaDaMaria);
//Console.WriteLine($"O saldo da conta  de {contaDoAndre.titular} pós-transfência é de R$ {contaDoAndre.saldo}.");

//Console.WriteLine($"O saldo da conta  de {contaDaMaria.titular} pós-transfência é de R$ {contaDaMaria.saldo}.");


//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Silva";
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_Agencia);
//Console.WriteLine(contaDoPedro.conta);


//double valor = 300;
//double valor2 = valor;

//Console.WriteLine(valor == valor2);
//Console.WriteLine(valor);
//Console.WriteLine(valor2);

//Cliente cliente = new Cliente(); 
//cliente.nome = "Andre Silva";
//cliente.cpf = "1234567890";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-x";
//conta.numero_Agencia = 15;
//conta.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular=new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "2345678901";
//conta2.conta = "1011-x";
//conta2.numero_Agencia = 16;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//Console.WriteLine($"Titular = {conta.titular.nome}");
//Console.WriteLine($"Titular = {conta.titular.cpf}");
//Console.WriteLine($"Titular = {conta.titular.profissao}");
//Console.WriteLine($"Titular = {conta.conta}");
//Console.WriteLine($"Titular = {conta.numero_Agencia}");
//Console.WriteLine($"Titular = {conta.saldo}");


//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_Agencia = 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo(50);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_Agencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18, "1012-X");
//conta4.SetSaldo(500);

//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_Agencia);


ContaCorrente conta5 = new ContaCorrente(283,"1234-x");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
ContaCorrente conta6 = new ContaCorrente(284, "9784-z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas) ;
ContaCorrente conta7 = new ContaCorrente(285, "1111-z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);