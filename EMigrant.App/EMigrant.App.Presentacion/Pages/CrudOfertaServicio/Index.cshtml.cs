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
    public class IndexModel : PageModel
    {
        public string NombreSort { get; set; }

        public string VersionSort { get; set; }

        public string Busqueda { get; set; }

        public string tpAllegado { get; set; }

        public string allegadoId { get; set; }

        public string IdentificacionAllegado { get; set; }

        private readonly EMigrant.App.Persistencia.Conexion _context;

        public IndexModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IList<OfertaServicio> OfertaServicio { get;set; }
        public void OnGet(string sortOrder, string Busqueda)
        {

            var usernamemigrante = HttpContext.Session.GetString("usernameinstitucion");
            if(!String.IsNullOrEmpty(usernamemigrante)){
                Console.WriteLine("usernamemigrante: "+usernamemigrante);
                OfertaServicio =  _context.OfertaServicios.Where(c => c.Institucion == usernamemigrante).ToList();
            } else {
                OfertaServicio = _context.OfertaServicios.ToList();
            }
              //Allegado = await _context.Allegados.ToListAsync();

            NombreSort = String.IsNullOrEmpty(sortOrder) ? "nombre_sort" : "";
            VersionSort = String.IsNullOrEmpty(sortOrder) ? "version_sort" : "";
            List<OfertaServicio> OfertaServiciosOrder = _context.OfertaServicios.ToList();

            if (!String.IsNullOrEmpty(Busqueda))
            {

                OfertaServiciosOrder = _context.OfertaServicios.Where(c => c.EstadoServicio == Busqueda).ToList();
                IdentificacionAllegado = Busqueda;
                // HttpContext.Session.SetString("IdentificacionAllegado", Busqueda);
                //Console.WriteLine("IdentificacionAllegado en busqueda: "+IdentificacionAllegado);
            }

            if (NombreSort != null && NombreSort.Equals("nombre_sort"))
            {
                OfertaServiciosOrder = OfertaServiciosOrder.OrderBy(c => c.EstadoServicio).ToList();
            }
            else if (VersionSort != null && VersionSort.Equals("version_sort"))
            {
                OfertaServiciosOrder = OfertaServiciosOrder.OrderBy(c => c.EstadoServicio).ToList();
            }
            else
            {
                OfertaServiciosOrder = OfertaServiciosOrder.ToList();
            }
            OfertaServicio = OfertaServiciosOrder.ToList();


            // if (tpAllegado != null)
            // {


            //     var usuario = HttpContext.Session.GetString("usernamemigrante");
            //     Console.WriteLine("este es:" + usuario);
            //     migrante migrante2 = _context.migrantes.FirstOrDefault(e => e.Usuario == usuario);
            //     IdentificacionAllegado = HttpContext.Session.GetString("IdentificacionAllegado");
            //     Console.WriteLine("IdentificacionAllegado: " + IdentificacionAllegado);

            //     migrante migrante3 = _context.migrantes.FirstOrDefault(e => e.TipoServicio == IdentificacionAllegado);
            //     if (migrante3 != null)
            //     {
            //         allegado.UsuarioId = usuario;

            //         allegado.IdAllegado = migrante3.Id;
            //         allegado.IdentificacionAllegado = IdentificacionAllegado;
            //         allegado.TipoAllegado = tpAllegado;
            //         allegado.NombreAllegado = migrante3.Nombre;

            //         _context.Allegados.Add(allegado);
            //         _context.SaveChanges();

            //     }





            // }

        }
    }
}
