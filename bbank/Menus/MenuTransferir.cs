using bbank.Models;
using System;

namespace bbank.Menus;
internal class MenuTrasnferir : Menu {

    public Conta verificarExistencia(int numero, List<Conta> contas) {
        foreach (Conta conta in contas) {
            if (conta.Numero == numero) {
                return conta;
            }
        }
        return null;
    }
    public override void Executar(List<Conta> contas) {
        base.Executar(contas);

        ExibirTitulo("Sacar");

        Console.Write("Digite o número da Conta de Origem:");
        string contaOrigemString = Console.ReadLine()!;
        int contaNumeroOrigem = int.Parse(contaOrigemString);

        Conta contaOrigem = verificarExistencia(contaNumeroOrigem, contas);
        if (contaOrigem == null) {
            Console.WriteLine("\n!!Conta de Origem não existente.\n");
            FinalizarOperacao(); 
        }

        Console.Write("Digite o número da Conta de Destino:");
        string contaDestinoString = Console.ReadLine()!;
        int contaNumeroDestino = int.Parse(contaDestinoString);

        Conta contaDestino = verificarExistencia(contaNumeroDestino, contas);
        if (contaDestino == null) {
            Console.WriteLine("\n!!Conta de Destino não existente.\n");
            FinalizarOperacao();
        }

        Console.Write("Digite valor que deseja tranferir R$:");
        string valor = Console.ReadLine()!;
        decimal valorNumérico = decimal.Parse(valor);
        Conta.Transferir(contaOrigem!, contaDestino!, valorNumérico);

        FinalizarOperacao();


    }
}

