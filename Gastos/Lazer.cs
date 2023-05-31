namespace Controles;
public class Lazer : Gastos
{
    private readonly decimal _bonus = 0m;
   
    public Lazer(string nome, decimal valorAtual, decimal bonus = 0) : base(nome, valorAtual) => _bonus = bonus; // Se não mover não executa o bônus

    public override void ExecutarMargemdeSeguranca()
    {
        decimal acrescimo = ValorAcumulado * 0.03m;
        AtualizarValor(acrescimo, DateTime.Now, "Margem de Segurança para Lazer");
        if (_bonus != 0)
        {
           AtualizarValor(_bonus, DateTime.Now, "Bonus para Lazer");
        }
    }
}