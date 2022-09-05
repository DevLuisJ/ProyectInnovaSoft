using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GymEnCasa.App.Dominio;
using GymEnCasa.App.Persistencia;


namespace GymEnCasa.App.Presentacion.Pages
{
    public class CrearUsuarioModel : PageModel
    {
        [BindProperty] // Aplica las validaciones para todos los objetos que se tiene las tomen cuando en la entidad
        //se definió [Required]
        public Usuario Usuario{get;set;}

        private readonly IRepositorioUsuario _repoUsuario; //Para conectarse a la base de datos

        public CrearUsuarioModel(IRepositorioUsuario repoUsuario)
            {
                _repoUsuario =repoUsuario;
            }
        public void OnGet()
            {
            }

        public async Task<IActionResult> OnPost()
            {
                if(!ModelState.IsValid)
                    {
                        return Page();
                    }
                    _repoUsuario.CrearUsuario(Usuario);
                    return RedirectToPage("/Index");
            }
           
    }
}
