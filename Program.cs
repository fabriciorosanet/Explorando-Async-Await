using System;
using System.Threading.Tasks;
class Program {
    static async Task Main (string[] args) {    
        Console.WriteLine("Iniciando a Aplicação...");

        //Executa uma tarefa de forma assíncrona

        Task tarefa1 = TarefaSimplesAsync(1);
        Task tarefa2 = TarefaSimplesAsync(2);
        Task tarefa3 = TarefaSimplesAsync(3);

        Console.WriteLine("Tarefas iniciadas, aguardando conclusão...");

        //Aguarda a conclusão de todas as tarefas

        await Task.WhenAll(tarefa1, tarefa2, tarefa3);

        Console.WriteLine("Todas as tarefas concluídas");
    }

    static async Task TarefaSimplesAsync(int numero)
    {
        Console.WriteLine($"Tarefa {numero} iniciada...");

        //Simula uma operação assíncrona com atraso

        await Task.Delay(5000);// espera 5 minutos

        Console.WriteLine($"Tarefa {numero} concluída após 5 segundos");
   }
}