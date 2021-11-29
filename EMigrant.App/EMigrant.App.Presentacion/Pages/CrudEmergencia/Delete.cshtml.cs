using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;

namespace EMigrant.App.Presentacion.Pages_CrudEmergencia
{
    public class DeleteModel : PageModel
    {
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public DeleteModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
        public Emergencia Emergencia { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Emergencia = await _context.Emergencias.FirstOrDefaultAsync(m => m.id == id);

            if (Emergencia == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Emergencia = await _context.Emergencias.FindAsync(id);

            if (Emergencia != null)
            {
                _context.Emergencias.Remove(Emergencia);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
