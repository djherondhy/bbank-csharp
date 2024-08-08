using bbank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bbank.Menus; 
internal class MenuListarContasSaldoMaior : Menu {
    public override void Executar(List<Conta> contas) {
        base.Executar(contas);

        ExibirTitulo("Lista de Contas com Saldo Maior Que 1000.");
        var contasSaldosMaior = contas.Where(c => c.Saldo > 1000).ToList();
        foreach (var conta in contasSaldosMaior) {
            Console.WriteLine($"{conta.RetornarTipo()}: {conta.Numero} | Titular: {conta.Titular}");
        }
        Console.WriteLine("");
        FinalizarOperacao();
    }


}
