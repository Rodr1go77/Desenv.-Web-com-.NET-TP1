using EXE10_ProductCatalog.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EX10.Pages
{

    public class Produto
    {
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }

    }

    public class IndexModel : PageModel
    {
        private readonly CatalogoProdutos _catalogo;

        public IndexModel(CatalogoProdutos catalogo)
        {
            _catalogo = catalogo;
        }

        public List<Produto> Produtos { get; set; } = new();

        public void OnGet()
        {
            Produtos = _catalogo.ObterTodos();
        }
    }
}
