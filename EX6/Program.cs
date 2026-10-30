/* EX6 Sistema de Registro com Multicast Delegate
Uma aplicação corporativa precisa registrar logs simultaneamente em 
vários destinos: console, arquivo e banco (simulado).

Tarefas:
Crie uma classe Logger com três métodos: LogToConsole, LogToFile, 
LogToDatabase.
Crie um Action<string> multicast delegate.
Adicione os três métodos ao delegate.
Ao chamar o delegate com uma mensagem, todas as saídas devem ser 
executadas.
Esse exercício reforça como delegates podem ser encadeados para 
criar comportamentos complexos com baixa acoplamento. 
*/
using System;
    
namespace EX6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Action<string> logMulticast = Logger.LogToConsole;
            logMulticast += Logger.LogToFile;
            logMulticast += Logger.LogToDatabase;

            logMulticast("Sistema iniciado com sucesso.");
        }
    }
}
