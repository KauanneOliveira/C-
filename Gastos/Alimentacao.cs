namespace Controles;

public class Alimentacao : Gastos
{
    public Alimentacao(string nome, decimal valorAtual) : base(nome, valorAtual)
    {
    }

    public override void ExecutarMargemdeSeguranca()
    {
        decimal acrescimo = ValorAcumulado * 0.01m;
        AtualizarValor(acrescimo, DateTime.Now, "Margem de Segurança para Alimentação"); 
    } 
}