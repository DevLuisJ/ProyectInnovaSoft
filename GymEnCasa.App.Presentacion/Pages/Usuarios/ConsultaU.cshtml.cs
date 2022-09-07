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
    public class ConsultaUModel : PageModel
    {
          private readonly IRepositorioUsuario _repoUsuario; //Para conectarse a la base de datos

          public IEnumerable<Usuario> listaUsuario{get;set;}

            public ConsultaUModel(IRepositorioUsuario repoUsuario)
            {
                _repoUsuario =repoUsuario;
            }
        public void OnGet()
        {
            listaUsuario = new List<Usuario>();
            listaUsuario =_repoUsuario.ConsultarUsuarios();
        }
    }
}
