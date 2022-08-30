using System;

namespace GymEnCasa.App.Dominio
{
    public class Usuario:Persona
    {
        //public int Id {get;set;}
        //Heredado desde Persona
        public string Correo {get;set;}
        public string Contrasena {get;set;}
   }
}