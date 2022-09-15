using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Globalization;
using System.Text.RegularExpressions;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GymEnCasa.App.Dominio;
using GymEnCasa.App.Persistencia;

namespace GymEnCasa.App.Presentacion.Pages
{
    public class EditarUModel : PageModel
    {
        private readonly IRepositorioUsuario _repoUsuario;

         [BindProperty] // Aplica las validaciones para todos los objetos que se tiene las tomen cuando en la entidad
        //se definió [Required]

        public Usuario Usuario{get;set;}
        public bool Respuesta;

        public EditarUModel(IRepositorioUsuario repoUsuario)
        {
            _repoUsuario=repoUsuario;
        }
        public void OnGet(string usuarioCorreo)
        {
        
        }
        public async Task<IActionResult> OnPost()
        {  
            Console.WriteLine(Usuario.Correo);

             //Verifica si el correo es válido
            Respuesta= IsValidEmail(Usuario.Correo);
            Console.WriteLine(Respuesta);
            
            if(Respuesta==false)
                {
                //alert("Correo electrónico invalido");
                return Page(); 
                }
            else 
                {
                    Usuario=_repoUsuario.ConsultarUsuarioCorreo(Usuario.Correo);
                     Console.WriteLine(Usuario.Id);
                    if(Usuario==null)
                        {
                        return RedirectToPage("/Error");
                        }
                        //return RedirectToPage("/Usuarios/EditarU2");
                        return Page();
                }
            
        }  // Fin de public async Task<IActionResult> OnPost()

        public async Task<IActionResult> OnPostEdit()
        {
            Console.WriteLine("Usuario a actualizar: " + Usuario.Id);
            Usuario=_repoUsuario.ActualizarUsuario(Usuario);
            Console.WriteLine("Actualizando usuario");
            
                     
            if(Usuario!=null)
               {
                Console.WriteLine("Usuario no es null");
                return RedirectToPage("/Usuarios/ConsultaU");
               }
               else
                {
                Console.WriteLine("Usuario  es null");
                return RedirectToPage("/Error");
                }      
        } // fin de public async Task<IActionResult> OnPostEdit() 

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }  // fin de public static bool IsValidEmail(string email)
 
    }
}