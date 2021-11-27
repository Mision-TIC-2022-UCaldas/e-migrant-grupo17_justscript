using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;

namespace EMigrant.App.Presentacion.Pages.CrudInstitucion
{
    public class CreateModel : PageModel
    {
        private readonly EMigrant.App.Persistencia.Conexion _context;

        public SelectList SeleccionInstitucion;
        public CreateModel(EMigrant.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {

            //List<Institucion> ListaInsitucion = _context.Instituciones.ToList();
            //stringSeleccionInstitucion = new SelectList(ListaInsitucion, nameof(Institucion.Nit));
            return Page();
        }

        [BindProperty]
        public Institucion Institucion { get; set; }

        [BindProperty]
        public string NitInstitucion { get; set; }

        [BindProperty]
        public string ErrorInstitucion { get; set; }




        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            _context.Instituciones.Add(Institucion);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");

        }


    }

}


