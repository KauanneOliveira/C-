namespace CtlAbastec;
public class DieselS08 : Abastecimentos
{
    public DieselS08(string nome, decimal valorAtual) : base(nome, valorAtual) { }

    public override void ExecutarAjustes()
    {
        decimal acrescimo = ValorAcumulado * 0.03m;
        AtualizarValor(acrescimo, DateTime.Now, "Ajustes para Diesel S-8");
    } 
} 