using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GymEnCasa.App.Dominio;

namespace GymEnCasa.App.Presentacion.Pages
{
    public class CrearUsuarioModel : PageModel
    {
        public Persona Persona{get;set;}
        public void OnGet()
        {
        }
    }
}
