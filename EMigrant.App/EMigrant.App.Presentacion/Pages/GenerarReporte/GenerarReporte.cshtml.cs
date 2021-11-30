using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EMigrant.App.Dominio;




namespace EMigrant.App.Presentacion.Pages
{
    public class GenerarReporteModel : PageModel
    {
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public GenerarReporteModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IList<Institucion> Institucion { get;set; }
        public IList<OfertaServicio> OfertaServicios { get;set; }

        public String html_contenido{ get;set; }

        public IList<String> numerosServiciosDisponibles{ get;set; }

        public IList<String> servicios{get;set;}

        public IList<String> numeroServiciosTipo{get;set;}

        public void OnGet(){
            
            Institucion = _context.Instituciones.ToList(); 
            OfertaServicios = _context.OfertaServicios.ToList();
            numerosServiciosDisponibles = new List<string>();
            servicios = new List<string>{"Salud","Jurídico", "Empleo", "Víveres", "Comida_preparada", "Alojamiento_temporal", "Alojamiento_permanente", "Educacion", "Otros"};
            numeroServiciosTipo = new List<string>();
            

            // _context.OfertaServicios.Where(c => c.Institucion == Institucion.).ToListAsync();
            // _context.OfertaServicios.GroupBy()

            // _context.OfertaServicios.GroupBy(n => new { n.Institucion, n.car})
            //     .Select(g => new {
            //                    g.Key.PersonId,
            //                    g.Key.car)}).ToList();
            // var l = _context.Instituciones.Join(
            //     OfertaServicios,
            //     post => post.RazonSocial,
            //     meta => meta.Institucion,
            //     (post, meta) => new { Post = post, Meta = meta }
            // ).ToList();

            // Console.WriteLine("l:"+l.ToString());

            // _context.Instituciones.Where(c=>c.RazonSocial==)
            

            foreach (var item in Institucion)
            {
                Console.WriteLine("Institucion:"+item.RazonSocial);
                // html_contenido = "<h3> "+item.RazonSocial+": ";
                var serviciosInstitucion = _context.OfertaServicios.Where(c => c.Institucion == item.RazonSocial).ToList();
                if(serviciosInstitucion!=null){
                    Console.WriteLine("Numero Servicios Institucion: "+serviciosInstitucion.Count().ToString());
                    // html_contenido+=" "+serviciosInstitucion.Count().ToString()+" </h3>";
                    numerosServiciosDisponibles.Add(serviciosInstitucion.Count().ToString());
                }
            }


            foreach (var item in servicios )
            {
                Console.WriteLine("Servicio:"+item);
                // html_contenido = "<h3> "+item.RazonSocial+": ";
                var tipoServicios = _context.OfertaServicios.Where(c => c.TipoServicio == item).ToList();
                
                if(tipoServicios!=null){
                    Console.WriteLine("Numero Servicios Por tipo: "+tipoServicios.Count().ToString());
                    // html_contenido+=" "+serviciosInstitucion.Count().ToString()+" </h3>";
                    numeroServiciosTipo.Add(tipoServicios.Count().ToString());
                }
            }
 

        }


    }
}
