

using bbank.Models;

namespace bbank.Menus;
internal class MenuExibirContas: Menu {

    public override void Executar(List<Conta> contas) {
        base.Executar(contas);

        ExibirTitulo("Lista de Contas");

        foreach (var conta in contas) {
            Console.WriteLine($"{conta.RetornarTipo()}: {conta.Numero} | Titular: {conta.Titular}");
        }
        Console.WriteLine("");
        FinalizarOperacao();
    }                                
}
