namespace Controles;

public class Educacao : Gastos
{
    public Educacao(string nome, decimal valorAtual) : base(nome, valorAtual)
    {
    }

    public override void ExecutarMargemdeSeguranca()
    {
        decimal acrescimo = ValorAcumulado * 0.04m;
        AtualizarValor(acrescimo, DateTime.Now, "Margem de Segurança para Educação"); 
    } 
}