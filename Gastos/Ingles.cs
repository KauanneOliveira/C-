namespace Controles;

public class Ingles : Gastos
{
    public Ingles(string nome, decimal valorAtual) : base(nome, valorAtual)
    {
    }

    public override void ExecutarMargemdeSeguranca()
    {
        decimal acrescimo = ValorAcumulado * 0.03m;
        AtualizarValor(acrescimo, DateTime.Now, "Margem de Segurança para Inglês"); 
    } 
}