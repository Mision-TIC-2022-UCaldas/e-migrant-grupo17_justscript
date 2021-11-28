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

namespace EMigrant.App.Presentacion.Pages_CrudEmergencia
{
    public class IndexModel : PageModel
    {
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public IndexModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IList<Emergencia> Emergencia { get;set; }

        // public void OnGet(){
        //     Emergencia emergencia = new Emergencia();
        //     emergencia.ciudad = "dfghj";
            
        //     _context.Emergencias.Add(emergencia);
        //     _context.SaveChanges();
        // }

        public async Task OnGetAsync()
        {

            var usernamemigrante = HttpContext.Session.GetString("usernamemigrante");
            if(!String.IsNullOrEmpty(usernamemigrante)){
                Console.WriteLine("usernamemigrante: "+usernamemigrante);
                Emergencia = await _context.Emergencias.Where(c => c.reportadaPor == usernamemigrante).ToListAsync();
                
            } else {
                Emergencia = await _context.Emergencias.ToListAsync();
            }

            

        }
    }
}
