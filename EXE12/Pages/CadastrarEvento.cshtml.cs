
using System;
using EXE12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EXE12.Pages
{
    public class AddEventModel : PageModel
    {

        [BindProperty]
        public Event NovoEvento { get; set; } = new Event();
        public bool EventoCriado { get; set; }

        public void OnGet()
        {
            EventoCriado = false;
            NovoEvento = new Event();
        }

        private void ImprimirEvento(Event evento)
        {
            Console.WriteLine($"Evento: {evento.Titulo}, Data: {evento.Data?.ToString("dd/MM/yyyy") ?? "Sem data"}, Local: {evento.Local}");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Action<Event> disparador = ImprimirEvento;
            disparador?.Invoke(NovoEvento);

            EventoCriado = true;
            return Page();
        }
    }
}
