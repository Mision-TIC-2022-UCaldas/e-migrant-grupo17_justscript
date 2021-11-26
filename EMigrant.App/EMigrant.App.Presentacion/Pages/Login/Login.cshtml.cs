using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using EMigrant.App.Persistencia;
using EMigrant.App.Dominio;


namespace EMigrant.App.Presentacion.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string usuario { get; set; }

        [BindProperty]
        public string clave { get; set; }
        [BindProperty]
        public string AlertaUsuario { get; set; }
        [BindProperty]
        public string AlertaPassword { get; set; }
        [BindProperty]
        public bool claveValidado { get; set; }


        public void OnGet()
        {


        }

        public IActionResult OnPost()
        {
            Conexion conexion = new Conexion();
            migrante migrante = conexion.migrantes.FirstOrDefault(e => e.Usuario == usuario);
            if (migrante != null)
            {
                if (migrante.Clave.Equals(clave))
                {
                    Console.WriteLine("Si esta entrando al if"); //comprobación si entra al if
                    HttpContext.Session.SetString("username", usuario);
                    return RedirectToPage("../CrudMigrante/Index");
                }


            }
        }
    }
}