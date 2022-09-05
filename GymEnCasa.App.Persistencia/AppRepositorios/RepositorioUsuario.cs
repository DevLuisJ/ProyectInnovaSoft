using GymEnCasa.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace GymEnCasa.App.Persistencia
{
    public class RepositorioUsuario:IRepositorioUsuario
    {
        
        //Se modifica porque se hace desde la Web
        private readonly AppContext _appContext = new AppContext();
        
        /* Ya no se necesita porque el servicio web se encarga de hacer la conexión a la base de datos
        
        private readonly AppContext _appContext;
        
        public  RepositorioUsuario (AppContext appContext)
        {
            this._appContext=appContext;
        }
        */

        //Crea o adiciona Usuario en la base de datos
        public  Usuario CrearUsuario (Usuario usuario)
        {
            var usuarioAdicionado = _appContext.Usuarios.Add(usuario);
            _appContext.SaveChanges();
            return usuarioAdicionado.Entity;
        }
        
        //Consulta Usuario en la base de datos
        public Usuario ConsultarUsuario(int idUsuario)
        {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(u=>u.Id==idUsuario); // u de usuario
             if (usuarioEncontrado!=null)
             {
                return usuarioEncontrado;
             }
            return null; 
        }
        
        //Consulta todos los Usuarios en la base de datos
        public IEnumerable <Usuario> ConsultarUsuarios()
        {
            return _appContext.Usuarios;

        }
        
         //Actualiza un Usuario en la base de datos
        public Usuario ActualizarUsuario (Usuario usuario)
         {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(u=>u.Id ==usuario.Id);
             if (usuarioEncontrado!=null)
             {
                usuarioEncontrado.Nombre = usuario.Nombre;
                usuarioEncontrado.Apellidos = usuario.Apellidos;
                usuarioEncontrado.Telefono = usuario.Telefono;
                usuarioEncontrado.Direccion = usuario.Direccion;
                usuarioEncontrado.FechaNacimiento = usuario.FechaNacimiento;
                usuarioEncontrado.Peso = usuario.Peso;
                usuarioEncontrado.Estatura = usuario.Estatura;
                usuarioEncontrado.Genero = usuario.Genero;
                usuarioEncontrado.IMC = usuario.IMC;
                usuarioEncontrado.ObjetivoPersonal = usuario.ObjetivoPersonal;
                usuarioEncontrado.Correo = usuario.Correo;
                usuarioEncontrado.Contrasena = usuario.Contrasena;
                
                _appContext.SaveChanges();
             }
             return usuarioEncontrado;
         }
        
         //Elimina un Usuario en la base de datos
         public void EliminarUsuario (int  idUsuario)
         {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(u=>u.Id == idUsuario);
             if (usuarioEncontrado==null)
                return;
            _appContext.Usuarios.Remove(usuarioEncontrado);
            _appContext.SaveChanges();
         }

    }
}
