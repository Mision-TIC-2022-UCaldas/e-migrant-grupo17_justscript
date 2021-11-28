using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;

namespace EMigrant.App.Presentacion.Pages.CrudNecesidad
{
    public class DetailsModel : PageModel
    {
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public DetailsModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public necesidades necesidades { get; set; }

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
    }
}
