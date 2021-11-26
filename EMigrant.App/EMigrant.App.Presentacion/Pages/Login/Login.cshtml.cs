// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.RazorPages;
// using Microsoft.AspNetCore.Http;
// using EMigrant.App.Persistencia;
// using EMigrant.App.Dominio;


// namespace Consolas.Front.Pages
// {
//     public class LoginModel : PageModel
//     {
//         [BindProperty]
//         public string usuario {get;set;}

//         [BindProperty]
//         public string clave {get;set;}
//         [BindProperty]
//         public string AlertaUsuario {get;set;}
//         [BindProperty]
//         public string Alertaclave {get;set;}
//         [BindProperty]
//         public bool claveValidado {get;set;}

//       public void OnGet()
//         {
//             // var claveValidado = HttpContext.Session.GetString("claveValidado");
//             // if(claveValidado != null){
//             //     claveValidado = true;
//             // }else{
//             //     claveValidado = false;
//             // }
//         }

//        public IActionResult OnPost(){
//           Conexion conexion = new Conexion();
//           migrante migrante = conexion.migrantes.FirstOrDefault(e => e.Usuario == usuario);    

//         if(migrante != null){
//             if(migrante.Clave.Equals(clave)){
//                 Console.WriteLine("Si esta entrando al if"); //comprobación si entra al if
//                 HttpContext.Session.SetString("username", usuario);


//         }
//         }
// /*
//             if(migrante.clave.Equals(clave)){
//                 HttpContext.Session.SetString("claveValidado", migrante.NombreRol.ToString());
//                 HttpContext.Session.SetString("ElUsuario", migrante.Usuario.ToString());
//                 Console.WriteLine(migrante.NombreRol.ToString());
//                 switch(migrante.NombreRol){
//                     case NombreRol.Administrador_Sistemas:
//                         return RedirectToPage("../Crudmigrante/Index");
//                     case NombreRol.Administrador_Compras:
                    
//                         return RedirectToPage("../CrudConsolas/Index");
//                     case NombreRol.Administrador_Ventas:
//                         return RedirectToPage("../CrudRegistroVenta/Index");
//                     case NombreRol.Vendedor:
//                         return RedirectToPage("../CrudRegistroVenta/Index");
//                     default:
//                         return RedirectToPage("../Index");                                                                        
//                 }
//             }else{
//                 Alertaclave = "clave incorrecto, intente de nuevo";
//                 return Page();       
//             }

//         }else{
//                AlertaUsuario = "El usuario no existe";
//                return Page();

//         }
// */
//        }
// }

// }
