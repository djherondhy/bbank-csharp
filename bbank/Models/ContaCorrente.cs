namespace bbank.Models;
internal class ContaCorrente : Conta
{
    public ContaCorrente(string titular) : base(titular) {

    }

    public override string RetornarTipo() => "Conta Corrente";
}
