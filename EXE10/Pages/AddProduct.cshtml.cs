using EX10.Pages;
using EXE10_ProductCatalog.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EXE10_ProductCatalog.Pages
{
    public class AddProductModel : PageModel
    {
        private readonly CatalogoProdutos _catalogo;

        public AddProductModel(CatalogoProdutos catalogo)
        {
            _catalogo = catalogo;
        }

        [BindProperty]
        public Produto Produto { get; set; } = new();

        public bool DadosEnviados { get; private set; }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            _catalogo.Adicionar(Produto);
            DadosEnviados = true;
        }
    }
}
