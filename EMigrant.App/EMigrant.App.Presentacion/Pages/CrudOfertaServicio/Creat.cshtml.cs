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
using Microsoft.EntityFrameworkCore;


namespace EMigrant.App.Presentacion.Pages.CrudOfertaServicio
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
          public string usuario {get;set;}

        public OfertaServicio OfertaServicio { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

             var usuario = HttpContext.Session.GetString("usernameinstitucion");
             Console.WriteLine("este es:" + usuario);
             Institucion institucion = _context.Instituciones.FirstOrDefault(e => e.Usuario == usuario);          
             Console.WriteLine(institucion.Id);

            if(OfertaServicio != null){
                OfertaServicio.InstitucionId = institucion.Id;
                _context.OfertaServicios.Add(OfertaServicio);
                await _context.SaveChangesAsync();

            }

            // OfertaServicio.InstitucionId = 1;
            // _context.OfertaServicios.Add(OfertaServicio);
            // await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
