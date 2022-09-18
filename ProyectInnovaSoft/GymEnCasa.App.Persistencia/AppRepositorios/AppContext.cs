using Microsoft.EntityFrameworkCore;
using GymEnCasa.App.Dominio;

namespace GymEnCasa.App.Persistencia
{
    public class AppContext:DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Usuario> Usuarios {get;set;}
        public DbSet<PlanDeNutricion> PlanDeNutricion {get;set;}
        public DbSet<PlanDeRutinas> PlanDeRutinas {get;set;}
                
        //TODO todos los Dbset con las entidades que van en base de datos
        //Los de tipo enum no van a base de datos

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
       {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog= DB_GymEnCasa");
            }
       }
    }
}
