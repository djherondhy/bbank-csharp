using bbank.Menus;

namespace bbank.Models;
internal class ContaInvestimento : Conta, ITributo {

    public decimal Tributo { get; set; }
    public ContaInvestimento(string titular) : base(titular) {

    }

    public decimal CalcularTributo() =>  Saldo* 0.02m;

    public override string RetornarTipo() => "Conta Investimentos";

}

