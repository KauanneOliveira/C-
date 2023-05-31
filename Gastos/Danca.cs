namespace Controles;

public class Danca : Gastos
{
    public Danca(string nome, decimal valorAtual) : base(nome, valorAtual)
    {
    }

    public override void ExecutarMargemdeSeguranca()
    {
        decimal acrescimo = ValorAcumulado * 0.02m;
        AtualizarValor(acrescimo, DateTime.Now, "Margem de Segurança para Dança"); 
    } 
}