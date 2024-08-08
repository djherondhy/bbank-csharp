using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bbank.Models; 
internal class TotalizadorDeContas {

    public static void totalizarContas(List<Conta> contas) {
        var totalConta = contas.Sum(c => c.Saldo);
               
        Console.WriteLine($"Total de Tributos: R${totalConta}");

    } 
}
