using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;

namespace EMigrant.App.Presentacion.Pages.CrudOfertaServicio
{
    public class IndexModel : PageModel
    {
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public IndexModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IList<OfertaServicio> OfertaServicio { get;set; }

        public async Task OnGetAsync()
        {
            OfertaServicio = await _context.OfertaServicios.ToListAsync();
        }
    }
}
