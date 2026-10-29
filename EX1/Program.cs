/* EX1 -  Implementação de Delegate Personalizado para Descontos
 
Imagine que você está desenvolvendo um módulo de regras de negócio para uma aplicação de 
vendas online. Esse sistema deve aplicar diferentes políticas de desconto conforme o 
perfil do cliente. Para isso, é necessário encapsular as regras de cálculo de desconto em 
uma estrutura reutilizável.

Tarefas:

Crie uma aplicação de console em C#.
Solicite ao usuário que informe o preço original de um produto.
Crie um delegate chamado CalculateDiscount que receba esse valor como decimal e retorne o 
preço com 10% de desconto aplicado.
Implemente um método compatível com esse delegate.
Utilize o delegate no fluxo da aplicação para calcular e exibir o valor final ao usuário.*/

using System.Globalization;

namespace EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal precoOriginal;

            while (true)
            {
                Console.Write("Informe o preço original do produto: ");
                string input = Console.ReadLine();


                if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.CurrentCulture, out precoOriginal) && precoOriginal > 0)
                {
                    break;
                }

                Console.WriteLine("Valor inválido. Informe um preço numérico positivo.");

            }

            Descontos.CalculateDiscount calculadora = Descontos.ApplyDiscount;

            decimal precoFinal = calculadora(precoOriginal);

            Console.WriteLine($"Preço final com desconto: {precoFinal:C}");
        }


    }
}
