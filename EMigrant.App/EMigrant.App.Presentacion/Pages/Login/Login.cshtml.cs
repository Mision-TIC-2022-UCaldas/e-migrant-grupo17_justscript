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
        public bool PasswordValidado { get; set; }


        public void OnGet()
        {
            /*   var passwordValidado = HttpContext.Session.GetString("passwordValidado");
               if(passwordValidado != null){
                   PasswordValidado = true;
               }else{
                   PasswordValidado = false;
               }*/

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
                    HttpContext.Session.SetString("usernamemigrante", usuario);
                    //HttpContext.Session.SetString("passwordValidado", migrante.Usuario.ToString());
                    return RedirectToPage("../Inicio/Inicio");
                }
                else
                {
                    AlertaPassword = "La Contraseña no es valida";
                    return Page();
                }
            }
            else
            {
                Institucion institucion = conexion.Instituciones.FirstOrDefault(e => e.Usuario == usuario);

                if (institucion != null)
                {
                    if (institucion.Clave.Equals(clave))
                    {
                        Console.WriteLine("Si esta entrando al if 2"); //comprobación si entra al if
                        HttpContext.Session.SetString("usernameinstitucion", usuario);
                        //HttpContext.Session.SetString("passwordValidado", migrante.Usuario.ToString());
                        return RedirectToPage("../Inicio/Inicio");
                    }
                    else
                    {
                        AlertaPassword = "La Contraseña no es valida";
                        return Page();
                    }
                }  else{
                    AlertaUsuario = "El usuario no existe";
                    return Page();
                }









                }
            }
        }
    }