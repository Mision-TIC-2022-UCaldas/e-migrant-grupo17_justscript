using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace EMigrant.App.Presentacion
{
    public class CerrarSesionModel : PageModel
    {
        public string usuario {get;set;}
        public IActionResult OnGet()
        {

            var usuario =  HttpContext.Session.GetString("usernameinstitucion");

            if(usuario == null){
                HttpContext.Session.Remove("usernamemigrante");
                 return RedirectToPage("../Index");
            }else {
                 HttpContext.Session.Remove("usernameinstitucion");
                  return RedirectToPage("../Index");
            }
            
           
        }
    }
}
