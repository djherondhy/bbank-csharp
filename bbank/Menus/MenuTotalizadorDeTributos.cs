using bbank.Models;
using System;

namespace bbank.Menus;
internal class MenuTotalizadorDeTributos : Menu {

    public override void Executar(List<Conta> contas) {
        base.Executar(contas);

        ExibirTitulo("Totalizador de Tributos");

        TotalizadorDeTributos.totalizarTributos(contas);
        FinalizarOperacao();
    }
}

