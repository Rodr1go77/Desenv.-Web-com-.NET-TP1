using EX10.Pages;

namespace EXE12.Services
{
    public class CatalogoProdutos
    {
        private readonly object _lock = new();
        private readonly List<Produto> _produtos = new()
        {
            new Produto { Nome = "Framework", Preco = 1000m },
            new Produto { Nome = "IDE", Preco = 800m },
            new Produto { Nome = "CSharp Language", Preco = 500m },
            new Produto { Nome = "Runtime Environment", Preco = 400m }
        };

        public List<Produto> ObterTodos()
        {
            lock (_lock)
            {
                return _produtos.ToList();
            }
        }

        public void Adicionar(Produto produto)
        {
            lock (_lock)
            {
                _produtos.Add(produto);
            }
        }
    }
}
