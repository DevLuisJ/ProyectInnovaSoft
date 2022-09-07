using System;
using System.ComponentModel.DataAnnotations; //Hacer validaciones

namespace GymEnCasa.App.Dominio
{
    public class Usuario:Persona
    {
        //public int Id {get;set;}
        //Heredado desde Persona
         [Required] // Hace que el Correo sea obligatorio/requerido
        public string Correo {get;set;}
        
         [Required] // Hace que el Correo sea obligatorio/requerido
        public string Contrasena {get;set;}
   }
}