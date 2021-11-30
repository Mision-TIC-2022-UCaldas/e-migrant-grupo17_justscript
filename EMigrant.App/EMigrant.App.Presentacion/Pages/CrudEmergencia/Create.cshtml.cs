using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;
using Microsoft.AspNetCore.Http;

namespace EMigrant.App.Presentacion.Pages_CrudEmergencia
{
    public class CreateModel : PageModel
    {
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public CreateModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Emergencia Emergencia { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var usernamemigrante = HttpContext.Session.GetString("usernamemigrante");

            if(!String.IsNullOrEmpty(usernamemigrante)){
                Emergencia.reportadaPor = usernamemigrante;
                Emergencia.estadoEmergencia = "En Espera";
                _context.Emergencias.Add(Emergencia);
                await _context.SaveChangesAsync();
            }


            

            return RedirectToPage("./Index");
        }
    }
}
