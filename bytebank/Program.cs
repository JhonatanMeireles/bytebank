using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_Agencia = 15;
contaDoAndre.conta = "1010-x";
contaDoAndre.saldo = 100;
Console.WriteLine($"O saldo da conta de {contaDoAndre.titular} é de R$ {contaDoAndre.saldo}.");



ContaCorrente contaDoAndre2 = new ContaCorrente();
contaDoAndre2.titular = "André Silva";
contaDoAndre2.numero_Agencia = 15;
contaDoAndre2.conta = "1010-x";
contaDoAndre2.saldo = 100;
Console.WriteLine($"O saldo da conta de {contaDoAndre2.titular} é de R$ {contaDoAndre2.saldo}.");
contaDoAndre = contaDoAndre2;

Console.WriteLine(contaDoAndre==contaDoAndre2);

contaDoAndre.ExibirInfoConta();
contaDoAndre2.ExibirInfoConta();
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


ContaCorrente conta = new ContaCorrente();

