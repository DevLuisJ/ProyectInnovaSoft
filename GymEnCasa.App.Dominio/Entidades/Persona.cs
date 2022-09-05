using System;
using System.ComponentModel.DataAnnotations;
namespace GymEnCasa.App.Dominio
{
    public class Persona
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Apellidos {get;set;}
        public string Telefono {get;set;}
        public string Direccion {get;set;}
        public DateTime FechaNacimiento {get;set;}
        public float Peso {get;set;}
        public float Estatura {get;set;}
        public Genero Genero {get;set;}
        public float IMC {get;set;}
        public ObjetivoPersonal ObjetivoPersonal {get;set;}
    }
}
