using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;

namespace EMigrant.App.Presentacion.Pages.CrudOfertaServicio
{
    public class DetailsModel : PageModel
    {
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public DetailsModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public OfertaServicio OfertaServicio { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OfertaServicio = await _context.OfertaServicios.FirstOrDefaultAsync(m => m.id == id);

            if (OfertaServicio == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
