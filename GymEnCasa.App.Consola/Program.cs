using System;
using System.Collections.Generic;
using GymEnCasa.App.Dominio;
using GymEnCasa.App.Persistencia;

namespace GymEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioUsuario _repoUsuario = new RepositorioUsuario (new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World - Creando Usuario!");
            //Adiciona el usuario creado a continuacion de forma manual
            AdicionarUsuario();
            
            // Consulta usuario
            BuscarUsuario(2);

            // Consulta todos los usuario
            BuscarTodosUsuarios();

        }
        
        //Buscar usuario en la base de datos
        private static void BuscarUsuario(int idUsuario)
        {
            var usuario = _repoUsuario.ConsultarUsuario(idUsuario);
            Console.WriteLine(usuario.Nombre + " " + usuario.Apellidos);
        }
        
        //Buscar todos los usuarios en la base de datos
        private static void BuscarTodosUsuarios()
        {
            IEnumerable <Usuario> listaUsuarios = _repoUsuario.ConsultarUsuarios();

            //Console.WriteLine(listaUsuarios(1).Nombre + " " + listaUsuarios(1).Apellidos);
        }
        
        // Adiciona usuarios para pruebas
        private static void AdicionarUsuario()
        {
            var usuario = new Usuario
            {
                Nombre = "Pedro Pablo",
                Apellidos = "Apellido1 Apellido2",
                Telefono = "1234331",
                Direccion = "Llegando a la esquina",
                FechaNacimiento = new DateTime(2000,02,20),
                Peso = 100F,
                Estatura = 173F,
                Genero = Genero.Masculino,
                IMC = 1.5F,
                ObjetivoPersonal = ObjetivoPersonal.ObjetivoPersonal1,
                Correo = "correo@correo.com",
                Contrasena = "Contrasena"
            };
            var usuario2 = new Usuario
            {
                Nombre = "Javier Enrique",
                Apellidos = "Apellido3 Apellido4",
                Telefono = "12344343",
                Direccion = "Llegando a la cuadra",
                FechaNacimiento = new DateTime(2002,02,22),
                Peso = 102F,
                Estatura = 153F,
                Genero = Genero.Masculino,
                IMC = 1.7F,
                ObjetivoPersonal = ObjetivoPersonal.ObjetivoPersonal2,
                Correo = "correo2@correo.com",
                Contrasena = "Contrasena2"
            };
        _repoUsuario.CrearUsuario(usuario);    
        _repoUsuario.CrearUsuario(usuario2);    

        }
    }
}
