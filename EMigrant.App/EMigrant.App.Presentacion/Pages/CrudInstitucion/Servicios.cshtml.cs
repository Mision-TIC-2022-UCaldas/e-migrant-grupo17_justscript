using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;

namespace EMigrant.App.Presentacion
{
    public class ServiciosModel : PageModel
    {
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public  ServiciosModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IList<Institucion> Institucion { get;set; }

        public async Task OnGetAsync()
        {
            Institucion = await _context.Instituciones.ToListAsync();
        }
    }
}
