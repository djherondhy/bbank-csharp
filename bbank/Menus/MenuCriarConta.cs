using bbank.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace bbank.Menus; 
internal class MenuCriarConta: Menu {

    public override void Executar(List<Conta> contas) {
        base.Executar(contas);

        ExibirTitulo("Criar Conta");
        Console.WriteLine("Tipos de Conta:");
        Console.WriteLine("1 - Conta Corrente.");
        Console.WriteLine("2 - Conta Poupança.");
        Console.WriteLine("3 - Conta Investimentos.");
        Console.Write("\nEscolha o Tipo de Conta que Deseja Criar:");
        Random random = new Random();

        string opcaoEscolida = Console.ReadLine()!;
        int opcaoNumerica = int.Parse(opcaoEscolida);
        switch (opcaoNumerica) {

            case 1:
                Console.Clear();
                Console.WriteLine("Você Escolheu Conta Corrente! \n");
                Console.Write("Digite o nome do titular: ");
                string titularCorrente = Console.ReadLine()!;

                int numeroDaContaCorrente = random.Next(0, 5000);

                foreach (var conta in contas) {
                    if (numeroDaContaCorrente == conta.Numero) {
                        numeroDaContaCorrente = random.Next(0, 5000);
                    }
                }
                ContaCorrente cc = new ContaCorrente(titularCorrente){ Numero = numeroDaContaCorrente};
                contas.Add(cc);
                Console.WriteLine($"Sua Conta foi criada com o número {numeroDaContaCorrente}!");
                Thread.Sleep(3000);

                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Você Escolheu Conta Poupança! \n");
                Console.Write("Digite o nome do titular: ");
                string titularPoupanca = Console.ReadLine()!;

                int numeroDaContaPoupanca = random.Next(0, 5000);

                foreach (var conta in contas) {
                    if(numeroDaContaPoupanca == conta.Numero) {
                        numeroDaContaPoupanca = random.Next(0, 5000);
                    }
                }
               

                ContaPoupanca cp = new ContaPoupanca(titularPoupanca) { Numero = numeroDaContaPoupanca };
                contas.Add(cp);
                Console.WriteLine($"Sua Conta foi criada com o número {numeroDaContaPoupanca}!");
                Thread.Sleep(3000);
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Você Escolheu Conta Corrente! \n");
                Console.Write("Digite o nome do titular: ");
                string titularInvestimento = Console.ReadLine()!;
                
                int numeroDaContaInvestimento = random.Next(0, 5000);
                foreach (var conta in contas) {
                    if (numeroDaContaInvestimento == conta.Numero) {
                        numeroDaContaInvestimento = random.Next(0, 5000);
                    }
                }

                ContaInvestimento ci = new ContaInvestimento(titularInvestimento) { Numero = numeroDaContaInvestimento };
                contas.Add(ci);
                Console.WriteLine($"Sua Conta foi criada com o número {numeroDaContaInvestimento}!");
                Thread.Sleep(3000);
                break;
        }

        FinalizarOperacao();

    }
}
