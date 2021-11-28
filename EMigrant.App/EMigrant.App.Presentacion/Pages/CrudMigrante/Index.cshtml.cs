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
    public class IndexModel : PageModel
    {

        public String NombreSort {get; set;}

        public String VersionSort {get; set;}

        public String Busqueda {get; set;}

        public String tpAllegado {get; set;}

        public String allegadoId {get; set;}


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
            }
            
            if(NombreSort != null && NombreSort.Equals("nombre_sort")){
                migranteOrder =  migranteOrder.OrderBy(c => c.NumeroDocumento).ToList();
            }else if(VersionSort != null && VersionSort.Equals("version_sort")){
                migranteOrder =  migranteOrder.OrderBy(c => c.NumeroDocumento).ToList();
            }else{
                migranteOrder =  migranteOrder.ToList();
            } 
            migrante = migranteOrder.ToList();   

            allegado.IdAllegado = 0;
            allegado.IdentificacionAllegado = Busqueda;
            allegado.TipoAllegado = tpAllegado;
            allegado.NombreAllegado = "Santiago";

            _context.Allegados.Add(allegado);
            _context.SaveChanges();
            


           
        }


        }
}
