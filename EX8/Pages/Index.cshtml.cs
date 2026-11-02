using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace EX8.Pages
{

    public class Produto
    {
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }

    }

    public class IndexModel : PageModel
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public void OnGet()
        {
            Produtos = new List<Produto>
            {
                new Produto { Nome = "Framework", Preco = 1000m },
                new Produto { Nome = "IDE", Preco = 800m },
                new Produto { Nome = "CSharp Language", Preco = 500m },
                new Produto { Nome = "Runtime Environment", Preco = 400m }
            };


        }

    }
}
