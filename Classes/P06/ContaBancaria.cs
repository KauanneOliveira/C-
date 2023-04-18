namespace Classes;
public class ContaBancaria 
{
    //membros são as propriedades e métodos

    //propriedades
    private static int numeroConta = 1234567890;
    public string Numero { get; } //get recupera
    public string Cliente { get; set; } //set permite modificação
    public decimal Saldo {
        get {
            decimal saldo = 0m;
            foreach (var item in todasTransacoes) {
                saldo += item.Quantia;
            }
            return saldo;
        }
    }

    //métodos

    public ContaBancaria(string nome, decimal saldoInicial) 
    {
        this.Cliente = nome;
        // this.Saldo = saldoInicial;
        this.Numero = numeroConta.ToString(); // tá usando o toString pq ta fazendo um casting, o Numero é uma string, mas o numeroConta é int
        numeroConta++;
        EfetuarDeposito(saldoInicial, DateTime.Now, "Saldo Inicial ");
    }

    private List<Transacao> todasTransacoes = new List<Transacao>();

    public void EfetuarDeposito(decimal quantia, DateTime data, string nota) 
    {  
        if (quantia <= 0) {
            throw new ArgumentOutOfRangeException(nameof(quantia), "A quantia de depósito deve ser positiva"); //a instrução throw mostra uma exceção
        }
        var deposito = new Transacao(quantia, data, nota);
        todasTransacoes.Add(deposito);
    }

    public void EfetuarSaque(decimal quantia, DateTime data, string nota) 
    {
        if (quantia <= 0) {
            throw new ArgumentOutOfRangeException(nameof(quantia), " A quantia de saque deve ser positiva");
        }
        if (Saldo - quantia < 0) {
            throw new InvalidOperationException("Fundo não suficiente para este saque");
        }
        var saque = new Transacao(-quantia, data, nota);  
        todasTransacoes.Add(saque);
    }

     public string ObterHistoricodeConta()
    {
    var relatorio = new System.Text.StringBuilder(); // StringBuilder é uma classe que pode ser usada quando você deseja modificar uma cadeia de caracteres sem criar um novo objeto

    decimal saldo = 0m;
    relatorio.AppendLine("Data\t\tQuantia\tSaldo\tNota"); //é um método que acrescenta o terminador de linha padrão ao final do atual objeto StringBuilder.
    foreach (var item in todasTransacoes)
    {
        saldo += item.Quantia;
        relatorio.AppendLine($"{item.Data.ToShortDateString()}\t{item.Quantia}\t{saldo}\t{item.Notas}");
    }

    return relatorio.ToString();
    }
    public virtual void ExecutarTransacoesdeFimdeMes() { }
}