using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;

namespace EMigrant.App.Presentacion.Pages.CrudInstitucion
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
        public Institucion Institucion { get; set; }
        public string nit { get; set; }
        public string Error {get;set;}

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            nit = Institucion.Nit;
             Institucion prueba = _context.Instituciones.FirstOrDefault(e => e.Nit == nit );

    
            if(prueba == null){
                 _context.Instituciones.Add(Institucion);
                 await _context.SaveChangesAsync();
                return RedirectToPage("./Index");

            }else{
                Error = "Error, el Nit ya exite, por favor intentelo con otro";
                return Page();
            }

 

        }
    }
}
