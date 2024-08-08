
using bbank.Models;
namespace bbank.Menus; 
internal class Menu {

    public virtual void Executar(List<Conta> contas) {
        Console.Clear();
    }

    public void ExibirTitulo(string titulo) {
        int tamTitulo = titulo.Length;
        string asteriscos = "" + string.Empty.PadRight(tamTitulo, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos);
        Console.WriteLine("");
    }

    public void FinalizarOperacao() {
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
        Console.ReadKey();
        Console.Clear();
    }
}
