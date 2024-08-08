using bbank.Menus;

namespace bbank.Models;
internal class Conta: IOperacaoes
{

    public int Numero { get; set; }
    public string Titular { get; set; }
    public decimal Saldo { get; set; }

    public Conta(string titular)
    {
        Titular = titular;
        Saldo = 0.00m;
    }

    public virtual void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public static void Transferir(Conta origem, Conta destino, decimal valor) {
        if(origem.Saldo > valor) {
            destino.Saldo += valor;
            origem.Saldo -= valor;
            Console.WriteLine("\nTranferência Realizada com Sucesso!\n");
        }
        else {
            Console.WriteLine("\nA conta de origem não possui saldo Suficiente para realizar a transferência!\n");
        }
    }

    public virtual void Sacar(decimal valor) {
        if (checarSaldoSuficiente(valor)) Saldo -= valor;
        else Console.WriteLine("\n!!Saldo Insuficiente para completar operação!\n"); return;

    }

    public bool checarSaldoSuficiente(decimal valor) {
        if (valor > Saldo) {
            return false;
        }
        return true;
        
    }

   

    public virtual string RetornarTipo() => "Conta Investimentos";
}
