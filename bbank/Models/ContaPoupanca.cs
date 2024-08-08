namespace bbank.Models;
internal class ContaPoupanca : Conta
{

    public ContaPoupanca(string titular) : base(titular)
    {

    }

    public override string RetornarTipo() => "Conta Poupança";

    public override void Sacar(decimal valor) {
       

        if (Saldo < valor + 0.10m) {
            Console.WriteLine("\n!!Saldo Insuficiente para completar operação!\n"); return;
        }
        else {
            Saldo -= 0.10m;
          
        }
       
    }

}
