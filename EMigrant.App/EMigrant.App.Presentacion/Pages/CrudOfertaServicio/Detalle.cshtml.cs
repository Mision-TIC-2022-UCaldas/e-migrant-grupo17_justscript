using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;
using Microsoft.AspNetCore.Http;


namespace EMigrant.App.Presentacion.Pages.CrudOfertaServicio
{
    public class DetalleModel : PageModel
    {

        public string usuario {get;set;}
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public DetalleModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public OfertaServicio OfertaServicio { get; set; }
       // public IList<OfertaServicio> OfertaServicio{ get; set; }

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
            public IActionResult OnPost(int id, string Institucion, string NombreServicio, DateTime FechaInicio, DateTime FechaFinalizacion, string EstadoServicio)
        {
             var usuario = HttpContext.Session.GetString("usernamemigrante");
             Console.WriteLine("este es:" + usuario);
             migrante migrante = _context.migrantes.FirstOrDefault(e => e.Usuario == usuario);          
             SolicitudServicio solicitudServicio = new SolicitudServicio();

             solicitudServicio.emigranteId = migrante.Id;
             solicitudServicio.InstitucionId = id;
             solicitudServicio.Usuario = usuario;
             solicitudServicio.Institucion = Institucion;
             solicitudServicio.NombreServicio = NombreServicio;
             solicitudServicio.FechaInicio = FechaInicio;
             solicitudServicio.FechaFinalizacion = FechaFinalizacion;
             solicitudServicio.EstadoServicio = EstadoServicio;

            _context.SolicitudServicios.Add(solicitudServicio);
            _context.SaveChanges();
            return RedirectToPage("./Servicios");
        }


    }
}
