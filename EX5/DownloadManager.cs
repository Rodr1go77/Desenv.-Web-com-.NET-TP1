using System;
using System.Threading;


namespace EX5
{
    internal class DownloadManager
    {
        public event Action<string>? DownloadCompleted;

        public void IniciarDownload(string fileName)
        {
            Console.WriteLine($"Iniciando download do arquivo: {fileName}");
            Thread.Sleep(3000); // 3 segundos
            Console.WriteLine($"Download do arquivo {fileName} concluído.");
            DownloadCompleted?.Invoke(fileName);
        }

    }
}
