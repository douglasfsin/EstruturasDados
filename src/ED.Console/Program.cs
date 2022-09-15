using ED.Fila;

class Program
{
    static void Main(string[] args){

        var filaAtendimento = new FilaAtendimento();
        
        filaAtendimento.GerarNovaSenha();
        filaAtendimento.GerarNovaSenha();
        filaAtendimento.GerarNovaSenha();
        filaAtendimento.GerarNovaSenha();
        
        filaAtendimento.MostrarFila();
        filaAtendimento.ChamarProximaSenha();
        filaAtendimento.ChamarProximaSenha();
        filaAtendimento.ChamarProximaSenha();

        filaAtendimento.GerarNovaSenha();
        filaAtendimento.ChamarProximaSenha();
        filaAtendimento.ChamarProximaSenha();
        filaAtendimento.MostrarFila();

        Console.ReadLine();
    }
}
