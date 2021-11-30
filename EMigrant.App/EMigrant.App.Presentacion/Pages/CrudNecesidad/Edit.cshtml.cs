using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;

namespace EMigrant.App.Presentacion.Pages.CrudNecesidad
{
    public class EditModel : PageModel
    {
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public EditModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
        public necesidades necesidades { get; set; }



        public SelectList SeleccionNecesidad;

     
        public string usuario {get;set;}


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            necesidades = await _context.Necesidad.FirstOrDefaultAsync(m => m.id == id);

            if (necesidades == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(necesidades).State = EntityState.Modified;

            try
            {
             var usuario = HttpContext.Session.GetString("usernamemigrante");
             Console.WriteLine("este es:" + usuario);
             migrante migrante = _context.migrantes.FirstOrDefault(e => e.Usuario == usuario); 

             if(migrante!=null){
                 necesidades.UsuarioId = migrante.Id;
             }
             

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!necesidadesExists(necesidades.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool necesidadesExists(int id)
        {
            return _context.Necesidad.Any(e => e.id == id);
        }
    }
}
