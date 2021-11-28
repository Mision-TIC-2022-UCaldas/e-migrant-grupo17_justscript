using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;

namespace EMigrant.App.Presentacion.Pages.CrudNecesidad
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
        public necesidades necesidades { get; set; }

        public SelectList SeleccionNecesidad;

     
        public string usuario {get;set;}

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
             //List<necesidades> listned = _context.migrantes.ToList();
             // SeleccionNecesidad = new SelectList(listned, nameof(necesidades.DescripcionSalud));


             var usuario = HttpContext.Session.GetString("usernamemigrante");
             Console.WriteLine("este es:" + usuario);
             migrante migrante = _context.migrantes.FirstOrDefault(e => e.Usuario == usuario);          
             migrante.necesidadId = SeleccionNecesidad.Count();

            _context.Necesidad.Add(necesidades);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }



    }
}
