using Classes;

var conta = new ContaBancaria("Renato Fernandez", 1000.50m); // 1000.50 é o saldo // o m é de monetário, de moeda, se não colocar isso ele va entender como float 

Console.Write($"A conta {conta.Numero} foi criada por {conta.Cliente} com saldo inicial de {conta.Saldo}\n\n");

conta.EfetuarSaque(500, DateTime.Now, "Pagamento de aluguel");
Console.WriteLine($"Saldo Atual de {conta.Saldo}\n");

conta.EfetuarDeposito(100, DateTime.Now, "Recebimento de um amigo");
Console.WriteLine($"Saldo Atual de {conta.Saldo}\n");