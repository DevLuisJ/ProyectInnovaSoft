using System;
using System.Collections.Generic;

namespace GymEnCasa.App.Dominio
{
    public class PlanDeNutricion:Persona
    {
        public DateTime Fecha {get;set;}
        
        public string FrecuenciaNutricion {get;set;}

        public float CaloriasQuemadas {get;set;}

        public float CaloriasAgregadas {get;set;}

        public string EstadoDieta {get;set;}

        public Dieta Dieta {get;set;}
    }
}