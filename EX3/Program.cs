/*EX3 - Cálculo de Área Utilizando Func

Um sistema de engenharia precisa realizar cálculos de área com base em entradas 
fornecidas pelo operador.

Tarefas:
Crie um programa de console em C#.
Solicite ao usuário que insira a base e a altura de um retângulo.
Crie um Func<double, double, double> para calcular a área.
Utilize o delegate para exibir o resultado ao final do processo.
Esse exercício demonstra o uso prático do Func como abstração de cálculos com retorno.*/

using System.Globalization;

namespace EX3
{
    internal class Program
    {

        public static double CalcularArea(double valorBase, double valorAltura) => valorBase * valorAltura;


        static void Main(string[] args)
        {
            double baseRetangulo;
            while (true)
            {
                Console.WriteLine("Informe a base do retângulo: ");
                string? input = Console.ReadLine();

                if (double.TryParse(input,NumberStyles.Number, CultureInfo.CurrentCulture, out baseRetangulo) && baseRetangulo > 0)
                {
                    break;
                }
                Console.WriteLine("Entrada inválida. Por favor, informe a base do retângulo: ");
                    
            }

            double alturaRetangulo;

            while (true)
            {
                Console.WriteLine("Informe a altura do retângulo: ");
                string? input = Console.ReadLine();

                if (double.TryParse(input,NumberStyles.Number, CultureInfo.CurrentCulture, out alturaRetangulo) && alturaRetangulo > 0)
                {
                    break;
                }
                Console.WriteLine("Entrada inválida. Por favor, informe a altura do retângulo: ");

            }

            Func<double, double, double> operacao = CalcularArea;
            double area = operacao(baseRetangulo, alturaRetangulo);

            Console.WriteLine($"Resultado da área: {area} m2");
        }
    }

}

