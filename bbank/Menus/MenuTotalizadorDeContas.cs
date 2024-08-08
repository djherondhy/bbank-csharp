using bbank.Models;
using System;

namespace bbank.Menus;
internal class MenuTotalizadorDeContas : Menu {

    public override void Executar(List<Conta> contas) {
        base.Executar(contas);

        ExibirTitulo("Totalizador de Contas");

        TotalizadorDeContas.totalizarContas(contas);
        FinalizarOperacao();
    }
}

