using bbank.Models;
using System;

namespace bbank.Menus;
internal class MenuVisualizarSaldo : Menu {

    public override void Executar(List<Conta> contas) {
        base.Executar(contas);

        ExibirTitulo("Visualizar Saldo");

        Console.Write("Digite o número da Conta:");
        string contaString = Console.ReadLine()!;
        int contaNumero = int.Parse(contaString);
        bool existe = false;
        foreach (var conta in contas) {
           
            if (contaNumero == conta.Numero) {
                Console.WriteLine($"Titular: {conta.Titular}");
                Console.WriteLine($"Saldo: R$ {conta.Saldo} \n");
                existe = true;
               
            }
        }
        if (!existe) Console.WriteLine("Esta conta não existe! \n");
        FinalizarOperacao();
    }
}

