using bbank.Menus;

namespace bbank.Models; 
internal class SeguroDeVida:Conta, IOperacaoes, ITributo {

    public decimal Tributo { get; set; }
    
    public SeguroDeVida(string titular) : base(titular) {

    }


    public override string RetornarTipo() => "Seguro de Vida";
    public decimal CalcularTributo() => 50.00m;

}
