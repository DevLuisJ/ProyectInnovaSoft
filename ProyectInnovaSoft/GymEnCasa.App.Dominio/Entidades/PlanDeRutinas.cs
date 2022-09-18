using System;
using System.Collections.Generic;

namespace GymEnCasa.App.Dominio
{
    public class PlanDeRutinas:Persona
    {
        public DateTime Fecha {get;set;}

        public string Rutina {get;set;}

        public string frecuenciaRutinas {get;set;}

        public int Repeticiones {get;set;}

        public string EstadoRutina {get;set;}

        public Rutinas Rutinas {get;set;}
    }
}
