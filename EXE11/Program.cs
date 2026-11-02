namespace EXE11
{
    internal class Program
    {

        static string Juntar(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}";
        }

        static string ConverterMaiscula(string nome, string sobrenome)
        {
            return $"{nome.ToUpper()} {sobrenome.ToUpper()}";
        }


        static string RemoverEspacos(string nome, string sobrenome)
        {
            return $"{nome.Trim()} {sobrenome.Trim()}";
        }


        static void Main(string[] args)
        {
            Func<string, string, string> operacao = Juntar;
            operacao += ConverterMaiscula;
            operacao += RemoverEspacos;
            string resultado = operacao("  rodrigo  ", "  bisol  ");
            Console.WriteLine($"Resultado obtido: '{resultado}'");
            Console.WriteLine("\n[Análise]:");
            Console.WriteLine("Em delegates multicast do tipo Func, todos os métodos da cadeia são executados,");
            Console.WriteLine("mas o valor de retorno capturado é unicamente o do último método da lista (RemoverEspacos).");
            Console.WriteLine("Por isso o texto não ficou em maiúsculas: o retorno de ConverterMaiuscula foi descartado.");
        }
    }
}
