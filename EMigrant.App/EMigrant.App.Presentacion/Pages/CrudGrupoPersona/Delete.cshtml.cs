using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;

namespace EMigrant.App.Presentacion.Pages.CrudGrupoPersona
{
    public class DeleteModel : PageModel
    {
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public DeleteModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
        public GrupoPersona GrupoPersona { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GrupoPersona = await _context.GrupoPersonas.FirstOrDefaultAsync(m => m.Id == id);

            if (GrupoPersona == null)
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

            GrupoPersona = await _context.GrupoPersonas.FindAsync(id);

            if (GrupoPersona != null)
            {
                _context.GrupoPersonas.Remove(GrupoPersona);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
