using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;

namespace EMigrant.App.Presentacion.Pages.CrudMigrante
{
    public class IndexModel : PageModel
    {

        public string NombreSort {get; set;}

        public string VersionSort {get; set;}

        public string Busqueda {get; set;}

        public string tpAllegado {get; set;}

        public string allegadoId {get; set;}

        public string IdentificacionAllegado {get;set;}


        private readonly EMigrant.App.Persistencia.Conexion _context;

        public IndexModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }
        
        public IList<migrante> migrante { get;set; }

        public void OnGet(string sortOrder, string Busqueda, int allegadoId, string tpAllegado)
        {

            Allegado allegado = new Allegado();

            NombreSort = String.IsNullOrEmpty(sortOrder) ? "nombre_sort": "";
            VersionSort = String.IsNullOrEmpty(sortOrder) ? "version_sort": "";
            List<migrante> migranteOrder = _context.migrantes.ToList();

            if(!String.IsNullOrEmpty(Busqueda)){
                migranteOrder = _context.migrantes.Where(c => c.NumeroDocumento == Busqueda).ToList();
                 IdentificacionAllegado = Busqueda;
            }
            
            if(NombreSort != null && NombreSort.Equals("nombre_sort")){
                migranteOrder =  migranteOrder.OrderBy(c => c.NumeroDocumento).ToList();
            }else if(VersionSort != null && VersionSort.Equals("version_sort")){
                migranteOrder =  migranteOrder.OrderBy(c => c.NumeroDocumento).ToList();
            }else{
                migranteOrder =  migranteOrder.ToList();
            } 
            migrante = migranteOrder.ToList();   


            if(tpAllegado != null){

        
             var usuario = HttpContext.Session.GetString("usernamemigrante");
             Console.WriteLine("este es:" + usuario);
             migrante migrante2 = _context.migrantes.FirstOrDefault(e => e.Usuario == usuario);  
            
            allegado.UsuarioId =  usuario;
            allegado.IdAllegado = allegadoId;
            allegado.IdentificacionAllegado = Busqueda;
            allegado.TipoAllegado = tpAllegado;
            allegado.NombreAllegado = "Santiago";

            _context.Allegados.Add(allegado);
            _context.SaveChanges();

            }
           
        }


        }
}
