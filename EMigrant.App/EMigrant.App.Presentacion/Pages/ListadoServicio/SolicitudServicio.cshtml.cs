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

namespace EMigrant.App.Presentacion
{
    public class SolicitudServicioModel : PageModel
    {
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public SolicitudServicioModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }


        public IList<SolicitudServicio> SolicitudServicio { get;set; }

        public async Task OnGetAsync()
        {
            SolicitudServicio = await _context.SolicitudServicios.ToListAsync();
        }
    }
    }

