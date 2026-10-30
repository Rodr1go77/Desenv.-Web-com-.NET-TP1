

/*EX4 - Monitoramento de Temperatura com Evento Personalizado

Sistemas embarcados em ambientes industriais monitoram sensores em tempo real. Uma 
funcionalidade comum é emitir alertas quando a temperatura ultrapassa o limite seguro.

Tarefas:

Crie uma classe TemperatureSensor com um evento TemperatureExceeded.
Solicite entradas do usuário para simular leituras de temperatura.
Dispare o evento sempre que o valor ultrapassar 100ºC.
Crie um manipulador que mostre um alerta no console.
Com este exercício, você aprende a usar eventos para tornar aplicações mais reativas e 
seguras.
*/
using System.Globalization;

namespace EX4
{
    internal class Program
    {

        static void TratarTemperaturaAlta(double temperatura)
        {
            Console.WriteLine($"Alerta: Temperatura excedeu o limite seguro! Valor: {temperatura}ºC");
        }


        static void Main(string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor();

            sensor.TemperatureExceeded += TratarTemperaturaAlta;

            Console.WriteLine("=== Monitoramento de Sensores Industriais ===");
            Console.WriteLine("Digite as temperaturas para simular as leituras (ou 'sair' para encerrar):");

            while (true)
            {
                Console.Write("\nInforme a temperatura lida (ºC): ");
                string? input = Console.ReadLine();

                if (string.Equals(input?.Trim(), "sair", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (double.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out double temperatura))
                {
                    // Envia a leitura para checagem do sensor
                    sensor.ChecarTemperatura(temperatura);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um valor numérico válido.");
                }
            }
        }
    }
}
