/* EX7 Garantia de Robustez em Invocação de Delegates
Ao usar delegates em tempo de execução, é fundamental garantir que invocações não gerem 
erros caso não haja métodos associados.

Tarefas:
Reutilize o código do exercício anterior (Logger).
Substitua todas as invocações diretas por chamadas usando ?.Invoke().
Teste o sistema sem nenhum método associado ao delegate e verifique que não ocorrem 
exceções.
Esse exercício promove boas práticas para escrita de código mais robusto.

 */

namespace EX7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Action<string>? logMulticast = null;
            Console.WriteLine("--- Teste 1: Delegate nulo com ?.Invoke() ---");
            logMulticast?.Invoke("Mensagem nao gera erro e não deve ser impressa.");


            logMulticast += Logger.LogToConsole;
            logMulticast += Logger.LogToFile;
            logMulticast += Logger.LogToDatabase;

            Console.WriteLine("\n--- Teste 2: Delegate com alvos registrados ---");
            logMulticast?.Invoke("Sistema iniciado com sucesso.");
        }
    }
}
