
namespace EX1
{
    internal class Descontos
    {
        public delegate decimal CalculateDiscount(decimal precoOriginal);

        public static decimal ApplyDiscount(decimal precoOriginal)
        {
            return precoOriginal * 0.9m; // 10% de desconto
        }

    }
}
