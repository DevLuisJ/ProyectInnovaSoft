using System;
using System.ComponentModel.DataAnnotations; //Hacer validaciones

namespace GymEnCasa.App.Dominio
{
    public class Persona
    {
        public int Id {get;set;}
        
        [Required] // Hace que el nombre sea obligatorio/requerido
        public string Nombre {get;set;}
        
        [Required] // Hace que el campo Apellido sea obligatorio/requerido
        public string Apellidos {get;set;}

        [Required] // Hace que el campo Telefono sea obligatorio/requerido
        public string Telefono {get;set;}
        
        [Required] // Hace que el campo sea obligatorio/requerido
        public string Direccion {get;set;}

        [Required] // Hace que el campo sea obligatorio/requerido
        public DateTime FechaNacimiento {get;set;}

        [Required] // Hace que el campo sea obligatorio/requerido
        public float Peso {get;set;}

        [Required] // Hace que el campo sea obligatorio/requerido
        public float Estatura {get;set;}

        [Required] // Hace que el campo sea obligatorio/requerido
        public Genero Genero {get;set;}

         // Por ahora no es obligatorio el IMC
         public float IMC {get;set;}
        
        [Required] // Hace que el campo sea obligatorio/requerido
        public ObjetivoPersonal ObjetivoPersonal {get;set;}
    }
}
