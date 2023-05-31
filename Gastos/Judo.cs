namespace Controles;

public class Judo : Gastos
{
    public Judo(string nome, decimal valorAtual) : base(nome, valorAtual)
    {
    }

    public override void ExecutarMargemdeSeguranca()
    {
        decimal acrescimo = ValorAcumulado * 0.02m;
        AtualizarValor(acrescimo, DateTime.Now, "Margem de Segurança para Judô"); 
    } 
}