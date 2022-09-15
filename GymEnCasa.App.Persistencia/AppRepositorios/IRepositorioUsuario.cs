// Es una INTERFACE  -Como si fuese un contrato.
using GymEnCasa.App.Dominio;
using System.Collections.Generic;

namespace GymEnCasa.App.Persistencia
{
    public interface IRepositorioUsuario
    {
        Usuario CrearUsuario (Usuario usuario);
        Usuario ConsultarUsuario (int  idUsuario);
        Usuario ConsultarUsuarioCorreo (string  CorreoUsuario);
        IEnumerable <Usuario> ConsultarUsuarios();
        Usuario ActualizarUsuario (Usuario usuario);
        void EliminarUsuario (int  idUsuario);
    }
}
