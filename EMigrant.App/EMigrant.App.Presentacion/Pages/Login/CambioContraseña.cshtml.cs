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
    public class CambioContraseñaModel : PageModel
    {
        [BindProperty]
        public string password { get; set; }


        [BindProperty]
        public string RepeatPassword { get; set; }

        [BindProperty]
        public string MensajePassword { get; set; }

        public void OnGet()
        {


        }

        public IActionResult OnPost()
        {
            Conexion conn = new Conexion();
            var Username = HttpContext.Session.GetString("usernamemigrante");
            if (Username != null)
            {
                //HttpContext.Session.Remove("username");
                migrante migrante = conn.migrantes.FirstOrDefault(e => e.Usuario == Username);
                if (!password.Equals(RepeatPassword))
                {
                    MensajePassword = "Las contraseñas no coinciden";
                    return Page();
                }
                else
                {
                    migrante.Clave = password;
                    conn.SaveChanges();
                    return RedirectToPage("../Login/Login");
                }
            }
            else
            {
                 var Username2 = HttpContext.Session.GetString("usernameinstitucion");
            if (Username2 != null)
            {
                //HttpContext.Session.Remove("username");
                Institucion institucion = conn.Instituciones.FirstOrDefault(e => e.Usuario == Username2);
                if (!password.Equals(RepeatPassword))
                {
                    MensajePassword = "Las contraseñas no coinciden";
                    return Page();
                }
                else
                {
                    institucion.Clave = password;
                    conn.SaveChanges();
                    return RedirectToPage("../Login/Login");
                }
            }
            else
            {
                return Page();
            }


        }
        }
    }
}
