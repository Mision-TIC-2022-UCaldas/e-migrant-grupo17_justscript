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

namespace EMigrant.App.Presentacion.Pages.CrudAllegado
{
    public class IndexModel : PageModel
    {
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public IndexModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IList<Allegado> Allegado { get;set; }

        public async Task OnGetAsync()
        {
            var usernamemigrante = HttpContext.Session.GetString("usernamemigrante");
            if(!String.IsNullOrEmpty(usernamemigrante)){
                Console.WriteLine("usernamemigrante: "+usernamemigrante);
                Allegado = await _context.Allegados.Where(c => c.UsuarioId == usernamemigrante).ToListAsync();
            } else {
                Allegado = await _context.Allegados.ToListAsync();
            }
              //Allegado = await _context.Allegados.ToListAsync();
        }
    }
}
