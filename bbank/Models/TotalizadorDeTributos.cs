namespace bbank.Models;
internal class TotalizadorDeTributos {

    public static void totalizarTributos(List<Conta> contas) {
        var totalTributos = contas
               .OfType<SeguroDeVida>()
               .Sum(c => c.CalcularTributo())
               + contas
               .OfType<ContaInvestimento>()
               .Sum(c => c.CalcularTributo());
        Console.WriteLine($"Total de Tributos: R${totalTributos}");

    }
  
}
