using Classes;

var conta = new ContaBancaria("Renato Fernandez", 1000.50m); // 1000.50 é o saldo // o m é de monetário, de moeda, se não colocar isso ele va entender como float 

Console.Write($"A conta {conta.Numero} foi criada por {conta.Cliente} com saldo inicial de {conta.Saldo}\n\n"); //A conta 1234567890 foi criada por Renato Fernandez com saldo inicial de 1000,50

conta.EfetuarSaque(500, DateTime.Now, "Pagamento de aluguel");
Console.WriteLine($"Saldo Atual de {conta.Saldo}\n"); //Saldo Atual de 500,50

conta.EfetuarDeposito(100, DateTime.Now, "Recebimento de um amigo"); //Saldo Atual de 600,50
Console.WriteLine($"Saldo Atual de {conta.Saldo}\n");
/*
try
{
    conta.EfetuarSaque(750, DateTime.Now, "Tentativa de saque sem saldo suficiente");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exceção causada por tentativa de saque sem saldo suficiente");
    Console.WriteLine(e.ToString());
}


ContaBancaria contaInvalida;

// Testar o saldo inicial - deve ser positivo.
try
{
    contaInvalida = new ContaBancaria("Inválida", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exceção causada ao criar conta com saldo negativo");
    Console.WriteLine(e.ToString());
    return;
}
*/

Console.WriteLine(conta.ObterHistoricodeConta());