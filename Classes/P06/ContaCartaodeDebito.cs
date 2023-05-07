namespace Classes;
public class ContaCartaodeDebito : ContaBancaria  //essa classe está herdando métodos e comportamentos da classe ContaBancaria
{
    private readonly decimal _depositosMensais = 0m;

    //Os parâmetros para esse novo construtor correspondem ao tipo de parâmetro e aos nomes do construtor de classe base
    // ":base()" serve para indicar uma chamada para um construtor de classe base(ContaBancaria)
    public ContaCartaodeDebito(string nome, decimal saldoInicial, decimal depositosMensais = 0) : base(nome, saldoInicial)
    => _depositosMensais = depositosMensais;
    public override void ExecutarTransacoesdeFimdeMes()
    {
        if (_depositosMensais != 0)
        {
            EfetuarDeposito(_depositosMensais, DateTime.Now, "Adicionar depositos mensais");
        }
    }
}
