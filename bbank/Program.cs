
using bbank.Models;
using bbank.Menus;

List<Conta> ListadeContas = new List<Conta>() {
    new ContaPoupanca("Monkey D. Luffy"){Numero = 4545, Saldo = 1000m},
    new ContaCorrente("Roronoa Zoro"){Numero = 5050, Saldo = 2000m},
    new ContaInvestimento("Vinsmoke Sanji"){Numero = 5555, Saldo = 1000m},
    new SeguroDeVida("Capitain Usopp"){Saldo = 1000m}
};
Dictionary<int, Menu> opcoes = new();

opcoes.Add(1, new MenuCriarConta());
opcoes.Add(2, new MenuExibirContas());
opcoes.Add(3, new MenuVisualizarSaldo());
opcoes.Add(4, new MenuDepositar());
opcoes.Add(5, new MenuSacar());
opcoes.Add(6, new MenuTrasnferir());
opcoes.Add(7, new MenuTotalizadorDeTributos());
opcoes.Add(8, new MenuListarContasSaldoMaior());
opcoes.Add(9, new MenuTotalizadorDeContas());
void ExibirMenu() {
    Console.WriteLine(@"
██████╗░██████╗░░█████╗░███╗░░██╗██╗░░██╗
██╔══██╗██╔══██╗██╔══██╗████╗░██║██║░██╔╝
██████╦╝██████╦╝███████║██╔██╗██║█████═╝░
██╔══██╗██╔══██╗██╔══██║██║╚████║██╔═██╗░
██████╦╝██████╦╝██║░░██║██║░╚███║██║░╚██╗
╚═════╝░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝");

    Console.WriteLine("Seja Bem Vindo ao BBank \n");
    Console.WriteLine("Menu de Opções");
    Console.WriteLine("1 - Criar Conta.");
    Console.WriteLine("2 - Listar Contas.");
    Console.WriteLine("3 - Visualizar Saldo");
    Console.WriteLine("4 - Depositar.");
    Console.WriteLine("5 - Sacar");
    Console.WriteLine("6 - Transferir");
    Console.WriteLine("7 - Relatório Totalizador de Tributos");
    Console.WriteLine("8 - Listar Contas com Saldo Maior que 1000,00 R$");
    Console.WriteLine("9 - Relatório Totalizar de Contas");

    Console.Write("\nEscolha uma opção:");
    
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcaoEscolhidaNumerica > 0) {
            Menu menu = opcoes[opcaoEscolhidaNumerica];
            menu.Executar(ListadeContas);
            ExibirMenu();
    }
    else {
        Console.WriteLine("Tchau!");
    }
}

ExibirMenu();