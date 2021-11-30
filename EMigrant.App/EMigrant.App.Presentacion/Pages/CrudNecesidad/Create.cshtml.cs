using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace EMigrant.App.Presentacion.Pages.CrudNecesidad
{
    public class CreateModel : PageModel
    {
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public CreateModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public necesidades necesidades { get; set; }

        public SelectList SeleccionNecesidad;

     
        public string usuario {get;set;}

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
             //List<necesidades> listned = _context.migrantes.necesidadId;
             //SeleccionNecesidad = new SelectList(listned, nameof(necesidades.DescripcionSalud));


             var usuario = HttpContext.Session.GetString("usernamemigrante");
             Console.WriteLine("este es:" + usuario);
             migrante migrante = _context.migrantes.FirstOrDefault(e => e.Usuario == usuario);          
             migrante.necesidadId = necesidades.id;



            var count_ = 0;
            //  _context.Necesidad.Count
            var co = (from a in  _context.Necesidad.AsEnumerable() select a).Count();
            
            if(co > 0){
                count_ = _context.Necesidad.Max(p => p.id);
            }
            
           
            Console.WriteLine(count_);


             
             //migrante.necesidadId = _context.Necesidad.Count();
             if(migrante!=null){
                 migrante.necesidadId = count_;
                 necesidades.UsuarioId = migrante.Id;
             }
             
            
            //  if(conta==null){
            //      idnes = 0;
            //  } else {
            //      idnes = conta;
            //  }
             

            
            //  migrante.necesidadId = necesidades.id;
            _context.Necesidad.Add(necesidades);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }



    }
}
