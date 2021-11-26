using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;

namespace EMigrant.App.Presentacion.Pages.CrudMigrante
{
    public class DetailsModel : PageModel
    {
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public DetailsModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public migrante migrante { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            migrante = await _context.migrantes.FirstOrDefaultAsync(m => m.Id == id);

            if (migrante == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
