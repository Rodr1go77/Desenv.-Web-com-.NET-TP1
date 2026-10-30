/*EX5 - Notificação de Conclusão de Download com Eventos
Ao lidar com tarefas assíncronas, como downloads, sistemas devem informar 
o usuário sobre a finalização do processo.

Tarefas:
Crie uma classe DownloadManager.
Simule o tempo de download usando Thread.Sleep.
Crie um evento DownloadCompleted.
Dispare o evento ao final do processo e exiba uma mensagem no console.
Este exercício ensina como eventos são utilizados para notificar o sistema 
sobre o fim de uma operação
*/

namespace EX5
{
    internal class Program
    {
        static void TratarDownloadConcluido(string nomeArquivo)
        {
            Console.WriteLine($"Evento: Download do arquivo '{nomeArquivo}' concluído com sucesso!");
        }


        static void Main(string[] args)
        {
            DownloadManager dwdManager = new DownloadManager();
            dwdManager.DownloadCompleted += TratarDownloadConcluido;
            dwdManager.IniciarDownload("arquivo.txt");
        }
    }
}
