using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;

namespace EMigrant.App.Presentacion.Pages.CrudMigrante
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
        public migrante migrante { get; set; }
        
        [BindProperty]
        public string usuario { get; set; }
         [BindProperty]
        public string Error {get;set;}
        

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            usuario = migrante.Usuario;
            migrante migrante2 = _context.migrantes.FirstOrDefault(e => e.Usuario == usuario);


            if(migrante2 == null){
            _context.migrantes.Add(migrante);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");

            }else{
                Error = "El usuario ya exite, intentelo con otro";
                return Page();
            }

        }
    }
}
