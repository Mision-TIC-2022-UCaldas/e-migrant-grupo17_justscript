using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;
using Microsoft.AspNetCore.Http;

namespace EMigrant.App.Presentacion.Pages.CrudOfertaServicio
{
    public class EditModel : PageModel
    {
        public string usuario{get;set;}

        public Institucion institucion {get;set;}
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public EditModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(OfertaServicio).State = EntityState.Modified;

            try
            {


             var usuario = HttpContext.Session.GetString("usernameinstitucion");
             Console.WriteLine("este es:" + usuario);
             Institucion institucion = _context.Instituciones.FirstOrDefault(e => e.Usuario == usuario);          
             Console.WriteLine("id es:" + institucion.Id);
             Console.WriteLine(OfertaServicio.NombreServicio);

            OfertaServicio.Institucion = institucion.RazonSocial;
            OfertaServicio.Usuario = usuario;
            OfertaServicio.TipoServicio = institucion.TipoServicio;
            OfertaServicio.InstitucionId = institucion.Id;



                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfertaServicioExists(OfertaServicio.id))
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

        private bool OfertaServicioExists(int id)
        {
            return _context.OfertaServicios.Any(e => e.id == id);
        }
    }
}
