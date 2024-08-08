using bbank.Models;
using System;

namespace bbank.Menus;
internal class MenuSacar : Menu {

    public override void Executar(List<Conta> contas) {
        base.Executar(contas);

        ExibirTitulo("Sacar");

        Console.Write("Digite o número da Conta:");
        string contaString = Console.ReadLine()!;
        int contaNumero = int.Parse(contaString);
        bool existe = false;
        foreach (var conta in contas) {
           
            if (contaNumero == conta.Numero) {
                Console.WriteLine($"\nTitular: {conta.Titular}");
                Console.WriteLine($"Saldo Atual : {conta.Saldo}\n");
                Console.WriteLine("!!Será cobrado uma taxa de transação de 0,10R$\n");
                Console.Write($"Digite o valor que deseja Sacar R$: \n");
                string valor = Console.ReadLine()!;
                decimal valorNumerico;
                decimal.TryParse(valor, out valorNumerico);
                conta.Sacar(valorNumerico);
              
                Console.WriteLine($"Saldo Após Operação : R$ {conta.Saldo}\n");
                existe = true;
                
            }


           
        }

        if (!existe) Console.WriteLine("Esta conta não existe! \n");

        FinalizarOperacao();


    }
}

